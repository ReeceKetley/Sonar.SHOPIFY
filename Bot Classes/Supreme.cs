using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using EO.WebBrowser;
using Newtonsoft.Json.Linq;
using SonarMULTI.Supreme_Classes;
using SonarSUPREME;
using SonarSUPREME.General_Classes;
namespace SonarSHOPIFY.Bot_Classes
{
    public class PostInfo
    {
        public string FormAction { get; private set; }
        public string SizeCode { get; private set; }

        public PostInfo(string formaction, string sizecode)
        {
            FormAction = formaction;
            SizeCode = sizecode;
        }
    }
    public class Supreme
    {
        private string Proxy { get; set; }
        public CookieContainer cookies;
        private HTTP _http;
        private string authToken;
        public ShopifySite Site;
        private bool LoadComplete;
        public ShopifyTask Task;
        private CheckoutCompleteForm frm;
        public string AddedUrl;
        public Supreme(ShopifySite site, ShopifyTask task, string proxy = "")
        {
            Proxy = proxy;
            Site = site;
            _http = new HTTP("Mozilla/5.0 (Windows NT 6.1; WOW64; rv:36.0) Gecko/20100101 Firefox/36.0", Proxy);
            _http.IncludeHeaderInResponse = false;
            Task = task;
            //frm = new CheckoutCompleteForm(Task);
            //frm.Show();
        }

        public AddToCartCode InitilizeSite()
        {

            var responce = _http.Get(Site.CartUrl);
            if (string.IsNullOrEmpty(responce))
            {
                return AddToCartCode.HttpError;
            }
            if (_http.LastStatusCode == HttpStatusCode.OK)
            {
                return AddToCartCode.Success;
            }
            return AddToCartCode.HttpError;
        }


        public AutoCheckoutResponse Checkout(BillingInfo billingInfo)
        {
            var posturl = Site.ProductsJson.Replace("products.json", "checkout");

            _http.AutoRedirect = false;
            Debug.WriteLine(posturl);
            var response = _http.Get(posturl);
            _http.AutoRedirect = true;
            posturl = _http.ResponseHeaders[HttpResponseHeader.Location];

            if (_http.LastStatusCode != HttpStatusCode.Found || _http.ResponseHeaders[HttpResponseHeader.Location] == null)
            {
                Debug.WriteLine("Oh dear");
                return new AutoCheckoutResponse(AddToCartCode.HttpError, _http.LastStatusCode.ToString());
            }
            response = _http.Get(posturl);
            authToken = Functions.ExtractBetween(response, "authenticity_token\" type=\"hidden\" value=\"", "\"").Trim();

            _http.Referer = Site.CartUrl;
            var year = billingInfo.CardExpiryYear;
            if (billingInfo.CardExpiryYear.Length == 4)
            {
                year  = billingInfo.CardExpiryYear.Replace("20", "");
            }


            var postFields = new Dictionary<string, string>();
            postFields.Add("utf8", "✓");
            postFields.Add("_method", "patch");
            postFields.Add("authenticity_token", authToken);
            postFields.Add("previous_step", "contact_information");
            postFields.Add("step", "shipping_method");
            postFields.Add("checkout[email]", billingInfo.Email);
            postFields.Add("checkout[shipping_address][first_name]", billingInfo.FirstName);
            postFields.Add("checkout[shipping_address][last_name]", billingInfo.LastName);
            postFields.Add("checkout[shipping_address][company]", "");
            postFields.Add("checkout[shipping_address][address1]", billingInfo.AddressLine1);
            postFields.Add("checkout[shipping_address][address2]", billingInfo.AddressLine2);
            postFields.Add("checkout[shipping_address][city]", billingInfo.City);
            postFields.Add("checkout[shipping_address][province]", billingInfo.StateOrCounty);
            postFields.Add("checkout[shipping_address][zip]", billingInfo.ZipOrPostalCode);
            postFields.Add("checkout[shipping_address][phone]", billingInfo.ContactNumber);
            postFields.Add("checkout[shipping_address][country]", billingInfo.Country);
            postFields.Add("checkout[activate_customer_account]", "0");
            postFields.Add("button", "");
            postFields.Add("checkout[client_details][browser_width]", "1903");
            postFields.Add("checkout[client_details][browser_height]", "903");

            var postData = "";

            foreach (var postField in postFields)
            {
                postData += HttpUtility.UrlEncode(postField.Key) + "=" + HttpUtility.UrlEncode(postField.Value) + "&";
            }
            _http.Referer = posturl + "?step=contact_information";
            var post = _http.Post(posturl, postData);

            // Shipping info post


            var shippingPost = new Dictionary<string, string>();
            shippingPost.Add("utf8", "✓");
            shippingPost.Add("_method", "patch");
            shippingPost.Add("authenticity_token", authToken);
            shippingPost.Add("previous_step", "shipping_method");
            shippingPost.Add("step", "payment_method");
            shippingPost.Add("checkout[shipping_rate_id]", "");

            var shippingPostData = "";

            foreach (var postField in postFields)
            {
                shippingPostData += HttpUtility.UrlEncode(postField.Key) + "=" + HttpUtility.UrlEncode(postField.Value) + "&";
            }
            post = _http.Post(posturl, shippingPostData);
            shippingPostData = "";
            if (_http.LastStatusCode != HttpStatusCode.Found)
            {
               // return new AutoCheckoutResponse(AddToCartCode.HttpError, "HttpError: Wrong response code.");
            }

            // Extract shipping info.

            if (post.Contains("The item you just added is unavailable. Please select another product or variant."))
            {
                return new AutoCheckoutResponse(AddToCartCode.InventoryIssue);
            }

            var shippingHTML = Functions.ExtractBetween(post, "=\"shopify-", "\"");

            _http.Referer = posturl + "?previous_step=contact_information&step=shipping_method";;
            var shippingPost1 = new Dictionary<string, string>();
            shippingPost.Clear();
            shippingPost1.Add("utf8", "✓");
            shippingPost1.Add("_method", "patch");
            shippingPost1.Add("authenticity_token", authToken);
            shippingPost1.Add("previous_step", "shipping_method");
            shippingPost1.Add("step", "payment_method");
            shippingPost1.Add("button", "");
            shippingPost1.Add("checkout[client_details][browser_width]", "1903");
            shippingPost1.Add("checkout[client_details][browser_height]", "903");
            shippingPost1.Add("checkout[shipping_rate_id]", "shopify-" + shippingHTML);

            shippingPostData = "";


            foreach (var postField in shippingPost1)
            {
                shippingPostData += HttpUtility.UrlEncode(postField.Key) + "=" + HttpUtility.UrlEncode(postField.Value) + "&";
            }
            post = _http.Post(posturl + "?previous_step=shipping_method&step=payment_method", shippingPostData);
            
            if (post.Contains("Inventory issues"))
            {
                return new AutoCheckoutResponse(AddToCartCode.InventoryIssue);
            }
            if (string.IsNullOrEmpty(post))
            {
                return new AutoCheckoutResponse(AddToCartCode.HttpError);
            }
            //File.WriteAllText("submit shipping.html", post);
            if (!post.Contains("<input name=\"c\" type=\"hidden\" value=\""))
            {
                return new AutoCheckoutResponse(AddToCartCode.PostError);
            }

            // submit card details

            var c = Functions.ExtractBetween(post, "<input name=\"c\" type=\"hidden\" value=\"", "\"");
            var paymentPostUrl = "";
            Regex regx = new Regex(@"https?://([-\w\.]+)+(:\d+)?(/([-\w/_\.]*(\?\S+)?)?)?", RegexOptions.IgnoreCase);
            MatchCollection mactches = regx.Matches(post);
            foreach (Match match in mactches)
            {
                if (match.Value.Contains("sessions"))
                {
                    paymentPostUrl = match.Value;
                    
                }
            }
            var d = Functions.ExtractBetween(post, "<input name=\"d\" type=\"hidden\" value=\"", "\"");
            //MessageBox.Show(paymentPostUrl);
            _http.AutoRedirect = false;
            _http.Referer = posturl + "?previous_step=shipping_method&step=payment_method";
            var paymentGateway = Functions.ExtractBetween(post, "data-select-gateway=\"", "\"");
            var cardNumber = billingInfo.CardNumber;
            var expiry = billingInfo.CardExpiryMonth;
            if (billingInfo.CardExpiryMonth.Length == 2 && billingInfo.CardExpiryMonth[0] == '0')
            {
                expiry = billingInfo.CardExpiryMonth.Replace("0", "");
            }
            var paymentPost = new Dictionary<string, string>();
            paymentPost.Add("utf8", "✓");
            paymentPost.Add("_method", "patch");
            paymentPost.Add("authenticity_token", authToken);
            paymentPost.Add("previous_step", "payment_method");
            paymentPost.Add("step", "");
            paymentPost.Add("c", c);
            paymentPost.Add("d", d);
            paymentPost.Add("checkout[payment_gateway]", paymentGateway);
            paymentPost.Add("checkout[credit_card][number]", cardNumber);
            paymentPost.Add("checkout[credit_card][name]", billingInfo.CardName);
            paymentPost.Add("checkout[credit_card][month]", expiry);
            paymentPost.Add("checkout[credit_card][year]", year);
            paymentPost.Add("checkout[credit_card][verification_value]", billingInfo.CardCVV);
            paymentPost.Add("checkout[different_billing_address]", "false");
            paymentPost.Add("checkout[buyer_accepts_marketing]", "0");
            paymentPost.Add("complete", "1");
            paymentPost.Add("button", "");
            paymentPost.Add("checkout[client_details][browser_width]", "1903");
            paymentPost.Add("checkout[client_details][browser_height]", "903");

            var paymentPostData = "";
            foreach (var postField in paymentPost)
            {
                paymentPostData += HttpUtility.UrlEncode(postField.Key) + "=" + HttpUtility.UrlEncode(postField.Value) + "&";
            }
            //File.WriteAllText("post.txt", paymentPostData);
            _http.AutoRedirect = true;
            
            //frm.SetCookies(paymentPostUrl, _http.Cookies);
            var request = new Request(paymentPostUrl);
            request.Method = "POST";
            foreach (var data in paymentPost)
            {
                request.PostData.AddValue(data.Key, data.Value);
            }
            request.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            request.Headers.Add("Origin", paymentPostUrl);
            request.Headers.Add("Referer", posturl + "?previous_step=payment_method&step=&validate=true");
            var paymentResponse = _http.Post(paymentPostUrl, paymentPostData);
            //MessageBox.Show("Redirect:" + paymentPostUrl);
            //MessageBox.Show("Status: " + _http.LastStatusCode);
            Task.UpdateStatus("Waiting for payment server response.");
            //Thread.Sleep(5000);
            paymentResponse = _http.Get(posturl + "/processing?previous_step=payment_method&step=");
            for (;;)
            {
                if (paymentResponse.Contains("\\/checkout\\/processing"))
                {
                    Debug.WriteLine("Wating for response");
                    paymentResponse = _http.Get(posturl + "/processing?previous_step=payment_method&step=");
                }
                else
                {
                    break;
                }

            }
            //paymentResponse = _http.Get(posturl + "/processing?previous_step=payment_method&step=");
            //File.WriteAllText("payment.html", paymentResponse);
            //m.SetCookies(_http.LastRedirectUrl, _http.Cookies);
            if (paymentResponse.Contains("\\/checkout\\/thank_you"))
            {
                return new AutoCheckoutResponse(AddToCartCode.Success);
            }
            if (paymentResponse.Contains("notice__text"))
            {
                //return new AutoCheckoutResponse(AddToCartCode.CardDeclined, "Credit Floor");
                var result = Functions.ExtractBetween(paymentResponse, "<p class=\"notice__text\">", "</p>").Trim();
                return new AutoCheckoutResponse(AddToCartCode.CardDeclined, result);
            }
            if (paymentResponse.Contains("<h4>Uh oh!</h4>"))
            {
                return new AutoCheckoutResponse(AddToCartCode.CardDeclined, Functions.ExtractBetween(paymentResponse, "<h4>Uh oh!</h4>", "</p>").Replace("<p>", "").Trim());
            }
            return new AutoCheckoutResponse(AddToCartCode.Fail);
            
        }





        private string Group4(string s)
        {
            string output = "";
            for (int i = 0; i < s.Length; i += 4)
                output += s.Substring(i, 4) + ' ';

            return s.TrimEnd();
        }



        public AutoCheckoutResponse AddToCart(Product product)
        {
            _http.IncludeHeaderInResponse = false;
            var response = _http.Post(Site.AddToCartUrl, "add=Purchase&id=" + product.ProductID);
            Debug.WriteLine(_http.LastStatusCode);
            Debug.WriteLine(response);
            if (string.IsNullOrEmpty(response))
            {
                return new AutoCheckoutResponse(AddToCartCode.HttpError, _http.ResponseExceptionString, _http);
            }
            if (response.Contains(product.ProductID))
            {
                AddedUrl = _http.LastRedirectUrl;
                return new AutoCheckoutResponse(AddToCartCode.Success);
            }
            if (_http.LastStatusCode == HttpStatusCode.BadRequest)
            {
                return new AutoCheckoutResponse(AddToCartCode.Fail);
            }
            return new AutoCheckoutResponse(AddToCartCode.HttpError);
        }

        public CookieContainer GetCookies()
        {
            return _http.Cookies;
        }

        public AutoCheckoutResponse GetProduct(string keyword, string size, string sku = null)
        {
            _http.IncludeHeaderInResponse = false;
            var result = _http.Get(Site.ProductsJson);
            _http.IncludeHeaderInResponse = true;
            if (string.IsNullOrEmpty(result))
            {
                return new AutoCheckoutResponse(AddToCartCode.Fail);
            }
            Product returnProduct = null;
            var productsObj = JObject.Parse(result);
            foreach (var prod in productsObj["products"])
            {
                var title = (string) prod["title"];
                var handle = (string) prod["handle"];
                string id;
                if (string.IsNullOrEmpty(sku))
                {
                    Debug.WriteLine("\r\n\r\n");
                    Debug.WriteLine(keyword.ToLower() + " - " + title);
                    if (title.ToLower().Contains(keyword.ToLower()))
                    {
                        Debug.WriteLine("Found MATCH!");
                        foreach (var sizes in prod["variants"])
                        {
                            if (sizes["title"].ToString().ToLower() == size.Trim().ToLower())
                            {
                                Debug.WriteLine("Found size\r\n\r\n");

                                //if ((bool) sizes["available"])
                                //{
                                    returnProduct = new Product((string) sizes["id"], title, (string) sizes["sku"],
                                        handle);
                                    return new AutoCheckoutResponse(AddToCartCode.Success, "", returnProduct);
                                //}
                            }
                        }
                        return new AutoCheckoutResponse(AddToCartCode.InventoryIssue);
                    }
                }
                else
                {
                    foreach (var sizes in prod["variants"])
                    {
                        Debug.WriteLine("HAS SKU: " + (string)sizes["sku"]);
                        if (sizes["sku"].ToString().Contains(sku.Trim()))
                        {
                            if ((string) sizes["title"] == size.Trim())
                            {
                                //if ((bool) sizes["available"])
                                //{
                                    Debug.WriteLine("FOUND SHIT");
                                    returnProduct = new Product((string) sizes["id"], title, (string) sizes["sku"],
                                        handle);
                                    return new AutoCheckoutResponse(AddToCartCode.Success, "", returnProduct);
                                //}
                            }
                        }
                    }
                    return new AutoCheckoutResponse(AddToCartCode.InventoryIssue);
                }
            }
            return null;
        }
    }
}
