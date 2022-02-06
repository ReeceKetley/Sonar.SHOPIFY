using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using EO.Internal;
using EO.WebBrowser;
using SonarMULTI.Supreme_Classes;
using SonarSUPREME;
using SonarSUPREME.General_Classes;
using Cookie = System.Net.Cookie;

namespace SonarSHOPIFY.Bot_Classes
{
    public partial class CheckoutCompleteForm : Form
    {
        public string Url;
        public BillingInfo Info;
        private ShopifyTask Task;
        public bool CookiesSet;
        public CookieContainer cookies;
        public bool contactSet;
        public bool Loaded;
        public ShopifySite Site;
        public int iStage;
        public string LastResponse;
        public string authToken;
        public CheckoutCompleteForm(ShopifyTask task)
        {
            InitializeComponent();
            Task = task;
            contactSet = true;
        }

        private void CheckoutCompleteForm_Load(object sender, EventArgs e)
        {
            wc.WebView.LoadCompleted += WebView_LoadCompleted;
            iStage = 0;
            contactSet = false;
        }

        void WebView_LoadCompleted(object sender, LoadCompletedEventArgs e)
        {
            Debug.WriteLine("Load finished: " + e.Url);
            LastResponse = e.Task.WebView.GetHtml();
            ++iStage;
            Loaded = true;
            if (!CookiesSet)
            {
                foreach (Cookie cookie in cookies.GetCookies(new Uri(Site.CartUrl)))
                {
                    Debug.WriteLine("Cookies: " + cookie.Value);
                    wc.WebView.EvalScript("document.cookie = \"" + cookie.Name + "=" + cookie.Value + "\";");

                }
                Task.UpdateStatus("Cookies set. Sending Customer info.");
                CookiesSet = true;
                wc.WebView.LoadUrl(Site.CartUrl);
                Debug.WriteLine("Starting autocheckout");

            }

        }



        public void SetBillingInfo(BillingInfo info)
        {
            Info = info;
        }

        public bool wLoaded()
        {
            while (!Loaded)
            {

            }
            Loaded = false;
            return true;
        }

        public void SetCookies(string url, CookieContainer c, ShopifySite site)
        {
            Task.UpdateStatus("Starting automatic checkout.");
            Url = url;
            cookies = c;
            Site = site;
            Thread t = new Thread(Start);
            t.Start();


        }

        public void Start()
        {
            this.Invoke((MethodInvoker)delegate
            {
                wc.WebView.LoadUrl(Site.CartUrl);
            });
        }


        public string Post(string url, Dictionary<string, string> post)
        {
            var request = new Request(url);
            var response = "";
            Debug.WriteLine("Post");
            request.Method = "POST";
            request.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            foreach (var p in post)
            {
                request.PostData.AddValue(p.Key, p.Value);
            }
            //this.Invoke((MethodInvoker)delegate
            //{
            Debug.WriteLine("Request");
            wc.WebView.LoadRequest(request);
            Debug.WriteLine("Status messagE: " + wc.WebView.StatusMessage);
            Debug.WriteLine("Done.");
            while (string.IsNullOrEmpty(wc.WebView.GetHtml()))
            {
                
            }
            response = wc.WebView.GetHtml();
            //});
            Debug.WriteLine("returning response");
            return response;
        }

        public string Get(string url)
        {
            var response = "";
            this.Invoke((MethodInvoker)delegate
            {
                wc.WebView.LoadUrl(url);
                if (string.IsNullOrEmpty(wc.WebView.GetHtml()))
                {
                    Thread.Sleep(3000);
                }
                response = wc.WebView.GetHtml();
            });
            Debug.WriteLine("Response: " + response + "\r\n");
            return response;
        }

       
        public void PageMoniter()
        {
            for (; ; )
            {

                Debug.WriteLine("Shipping.....");

            }
        }

        public void LoadRequest(Request request)
        {
            wc.WebView.LoadRequest(request);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            wc.WebView.EvalScript("document.getElementsByClassName(\"step__footer__continue-btn btn \")[0].click()");
        }

        private void wc_Click(object sender, EventArgs e)
        {

        }
    }
}
