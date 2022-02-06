using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using SonarSHOPIFY.Properties;
using SonarSNKRS;
using SonarSUPREME.General_Classes;

namespace SonarSHOPIFY.Bot_Classes
{
    public partial class AutoLearn : TemplateForm
    {
        public HTTP http = new HTTP("Mozilla/5.0 (Windows NT 6.1; WOW64; rv:40.0) Gecko/20100101 Firefox/40.0");
        public string url;
        public AutoLearn()
        {
            InitializeComponent();
        }

        private void AutoLearn_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            url = metroTextBox1.Text.Trim();
            metroTextBox1.Enabled = false;
            metroButton1.Enabled = false;
            Thread t = new Thread(Test);
            t.Start();
        }

        public void updateStatus(string status)
        {
            this.Invoke((MethodInvoker)delegate
            {
                metroLabel1.Text = Resources.AutoLearn_updateStatus_Status__ + status;
            });

        }

        public void Test()
        {
            updateStatus("Testing " + url);
            if (url.LastIndexOf('/') == -1)
            {
                url = url + "/";
            }
            var response = http.Get(url + "products.json");
            Debug.WriteLine(response);
            if (response.Contains("{\""))
            {
                updateStatus("Passed our first check.");
            }
            else
            {
                updateStatus(url + " Is not a shopify site.");
                return;
            }

            updateStatus("Site passed all checks and is shopify. Adding site.");
            this.Invoke((MethodInvoker)delegate
            {
                pictureBox3.Image = Resources.shopify;
            });
            ShopifySite site = new ShopifySite();
            site.SiteName = url;
            site.ProductsJson = url + "products.json";
            site.CartUrl = url + "cart";
            site.AddToCartUrl = url + "cart/add";
            site.ToJObject();
            SharedData.CustomSites.Add(site);
            SharedData.SaveCustomSites();
            MetroMessageBox.Show(this, "Added custom site.", "Site added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Invoke((MethodInvoker)delegate
            {
                Close();
            });
            
        }
    }
}
