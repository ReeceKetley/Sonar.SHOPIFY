using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using EO.Internal;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using Newtonsoft.Json.Linq;
using SonarSHOPIFY;
using SonarSHOPIFY.Bot_Classes;
using SonarSUPREME;
using SonarSUPREME.General_Classes;
using SonarSUPREME.Supreme_Classes;

namespace SonarMULTI.Supreme_Classes
{
    public partial class CreateTask : MetroForm
    {
        private SupremeMain MainForm;
        private ShopifySite Site;
        public CreateTask(SupremeMain mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void CreateTask_Load(object sender, EventArgs e)
        {
            SharedData.LoadBillingInfo();
            LoadCustom();
            foreach (var proxy in SharedData.Proxies)
            {
                metroComboBox1.Items.Add(proxy.ProxyString);
            }
            foreach (var billingInfo in SharedData.BillingInfos)
            {
                metroComboBox2.Items.Add(billingInfo.FullName);
            }
        }

        public void LoadCustom()
        {
            foreach (var site in SharedData.CustomSites)
            {
                listBox1.Items.Add(site.SiteName);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Site.SiteName))
            {
                MessageBox.Show("Please select a site first");
                return;
            }
            BillingInfo billing = new BillingInfo("","","","","","","","","","","","","","","","","","", "");
            string proxy = "";
            if (string.IsNullOrEmpty(txtKeyword.Text) || string.IsNullOrEmpty(txtSizeKeyword.Text))
            {
                MessageBox.Show("Missing Keyword or Size");
                return;
            }
            if (metroComboBox2.SelectedItem == null)
            {
                //return;
            }
            if (metroComboBox1.SelectedItem != null)
            {
                proxy = metroComboBox1.SelectedItem.ToString();
            }

            foreach (var billingInfo in SharedData.BillingInfos)
            {
                try
                {
                    if (billingInfo.FullName.Contains(metroComboBox2.SelectedItem.ToString()))
                    {
                        billing = billingInfo;
                    }
                }
                catch
                {
                    
                }
            }
            var taskConfig = new TaskConfig(txtKeyword.Text.Trim(), txtSizeKeyword.Text.Trim(), Site, tglFindBySku.Checked,
                txtSKU.Text.Trim(), billing, tglAutoCheckout.Checked);
            var Task = new ShopifyTask(taskConfig, proxy);
            MainForm.AddTask(Task);
            Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Site = ShopifySites.Sites[0];
            lblSite.Text = "Selected Site: " + Site.SiteName;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Site = ShopifySites.Sites[1];
            lblSite.Text = "Selected Site: " + Site.SiteName;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Site = ShopifySites.Sites[2];
            lblSite.Text = "Selected Site: " + Site.SiteName;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Site = ShopifySites.Sites[3];
            lblSite.Text = "Selected Site: " + Site.SiteName;
        }

        public void SetProduct(string text)
        {
            txtKeyword.Text = text;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (Site == null)
            {
                MessageBox.Show("Please select a site first");
                return;
            }
            ProductHelperForm frm = new ProductHelperForm(this, Site);
            frm.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Site = ShopifySites.Sites[4];
            lblSite.Text = "Selected Site: " + Site.SiteName;
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Site = ShopifySites.Sites[5];
            lblSite.Text = "Selected Site: " + Site.SiteName;
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Site = ShopifySites.Sites[6];
            lblSite.Text = "Selected Site: " + Site.SiteName;
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Site = ShopifySites.Sites[7];
            lblSite.Text = "Selected Site: " + Site.SiteName;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (this.Width > 1000)
            {
                this.Width = 651;
                listBox1.Visible = false;
            }
            else
            {
                this.Width = 1007;
                listBox1.Visible = true;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                foreach (var shopifySite in SharedData.CustomSites)
                {
                    if (shopifySite.SiteName == listBox1.SelectedItem.ToString())
                    {
                        Site = shopifySite;
                        lblSite.Text = "Selected Site: (Custom) " + listBox1.SelectedItem.ToString();
                    }
                }
            }
        
        }
    }
}
