using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using EO.WebBrowser;
using SonarSNKRS;
using Cookie = System.Net.Cookie;

namespace SonarSHOPIFY.Bot_Classes
{
    public partial class ManualCheckoutForm : TemplateForm
    {
        public CookieContainer Cookies;
        public ShopifySite Site;
        public bool CookiesSet;
        public ManualCheckoutForm(ShopifySite site, CookieContainer cookies)
        {
            InitializeComponent();
            Cookies = cookies;
            Site = site;
        }

        private void ManualCheckoutForm_Load(object sender, EventArgs e)
        {
            this.Text = "Manual Checkout - " + Site.SiteName;
            wb.WebView.JSExtInvoke += new EO.WebBrowser.JSExtInvokeHandler(WebView_JSExtInvoke  );
            wb.WebView.LoadCompleted += new LoadCompletedEventHandler(WebView_LoadCompleted);
            wb.WebView.LoadUrl(Site.CartUrl);
        }

        void WebView_LoadCompleted(object sender, LoadCompletedEventArgs e)
        {
            if (!CookiesSet)
            {
                foreach (Cookie cookie in Cookies.GetCookies(new Uri(Site.CartUrl)))
                {
                    Debug.WriteLine("Cookies: " + cookie.Value);
                    wb.WebView.EvalScript("document.cookie = \"" + cookie.Name + "=" + cookie.Value + "\";");

                }

                CookiesSet = true;
                wb.WebView.LoadUrl(Site.CartUrl);
            }
        }

        void WebView_IsLoadingChanged(object sender, EventArgs e)
        {
           
        }



        void WebView_JSExtInvoke(object sender, EO.WebBrowser.JSExtInvokeArgs e)
        {
            Debug.WriteLine(e.ReturnValue);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


        }
    }
}
