using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using EO.Internal;
using Newtonsoft.Json.Linq;
using SonarSHOPIFY.Bot_Classes;

namespace SonarSUPREME.General_Classes
{
    public static class SharedData
    {
        private static object _billingInfoFileMutex = new object();

        public static List<BillingInfo> BillingInfos = new List<BillingInfo>(); 
        public static List<Proxy> Proxies = new List<Proxy>();
        public static List<ShopifySite> CustomSites = new List<ShopifySite>();

        public static bool SaveCustomSites()
        {
            lock (_billingInfoFileMutex)
            {
                try
                {
                    JArray billinfJArray = new JArray();
                    foreach (var billingInfo in SharedData.CustomSites)
                    {
                        billinfJArray.Add(billingInfo.ToJObject());
                    }
                    File.Delete("CustomSites.json");
                    File.WriteAllText("CustomSites.json", billinfJArray.ToString());
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        public static bool LoadCustomSites()
        {
            lock (_billingInfoFileMutex)
            {
                try
                {
                    SharedData.CustomSites.Clear();
                    if (File.Exists("CustomSites.json"))
                    {
                        var jsonString = File.ReadAllText("CustomSites.json");
                        JArray billingArray = JArray.Parse(jsonString);
                        foreach (JToken billingToken in billingArray)
                        {
                            ShopifySite site = new ShopifySite();
                            site.SiteName = (string) billingToken["SiteName"];
                            site.ProductsJson = (string) billingToken["ProductsJson"];
                            site.CartUrl = (string) billingToken["CartUrl"];
                            site.AddToCartUrl = (string) billingToken["AddToCartUrl"] + ".js";
                            SharedData.CustomSites.Add(site);
                        }
                    }
                    else
                    {
                        File.Create("CustomSites.json");
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    return true;
                }
            }
            return true;
        }

        public static bool SaveBillingInfo()
        {
            lock (_billingInfoFileMutex)
            {
                try
                {
                    JArray billinfJArray = new JArray();
                    foreach (var billingInfo in SharedData.BillingInfos)
                    {
                        billinfJArray.Add(billingInfo.ToJObject());
                    }
                    File.Delete("Billing.json");
                    File.WriteAllText("Billing.json", billinfJArray.ToString());
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        public static bool LoadBillingInfo()
        {
            lock (_billingInfoFileMutex)
            {
                try
                {
                    SharedData.BillingInfos.Clear();
                    if (File.Exists("Billing.json"))
                    {
                        var jsonString = File.ReadAllText("Billing.json");
                        JArray billingArray = JArray.Parse(jsonString);
                        foreach (JToken billingToken in billingArray)
                        {
                            var card = Regex.Replace((string)billingToken["CardNumber"], ".{4}", "$0 ").Trim();
                            var billingInfo = new BillingInfo((string)billingToken["FirstName"],
                                (string)billingToken["LastName"], "03/04/88", (string)billingToken["ContactNumber"],
                                (string)billingToken["Email"], (string)billingToken["HouseNumber"],
                                (string)billingToken["AddressLine1"], (string)billingToken["AddressLine2"],
                                (string)billingToken["AddressLine3"], (string)billingToken["City"],
                                (string)billingToken["ZipOrPostalCode"], (string)billingToken["StateOrCounty"],
                                (string)billingToken["Country"], (string)billingToken["CardType"],
                                (string)billingToken["CardName"], card, (string)billingToken["CardExpiryMonth"],
                                (string)billingToken["CardExpiryYear"], (string)billingToken["CardCVV"]);
                            SharedData.BillingInfos.Add(billingInfo);
                        }
                    }
                    else
                    {
                        File.Create("Billing.json");
                    }
                }
                catch(Exception e)
                {
                    Debug.WriteLine(e.Message);
                    return true;
                }
            }
            return true;
        }
        public static bool SaveProxies()
        {
            lock (_billingInfoFileMutex)
            {
                try
                {
                    JArray billinfJArray = new JArray();
                    foreach (var billingInfo in SharedData.Proxies)
                    {
                        billinfJArray.Add(billingInfo.ToJObject());
                    }
                    File.Delete("Proxies.json");
                    File.WriteAllText("Proxies.json", billinfJArray.ToString());
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        public static bool LoadProxies()
        {
            lock (_billingInfoFileMutex)
            {
                try
                {
                    if (File.Exists("Proxies.json"))
                    {
                        var jsonString = File.ReadAllText("Proxies.json");
                        JArray billingArray = JArray.Parse(jsonString);
                        foreach (JToken billingToken in billingArray)
                        {
                            var proxy = new Proxy((string) billingToken["Proxy"]);
                            SharedData.Proxies.Add(proxy);
                        }
                    }
                    else
                    {
                        File.Create("Proxies.json");
                    }
                }
                catch
                {
                    return true;
                }
            }
            return true;
        }

    }
}
