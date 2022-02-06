using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
using SonarMULTI.Supreme_Classes;
using SonarSHOPIFY.Bot_Classes;
using SonarSNKRS;

namespace SonarSHOPIFY
{
    public partial class ProductHelperForm : TemplateForm
    {
        public ShopifySite Site;
        public CreateTask form;
        private HTTP _http;
        public ProductHelperForm(CreateTask frm, ShopifySite site)
        {
            InitializeComponent();
            form = frm;
            Site = site;
            _http = new HTTP("Mozilla/5.0 (Windows NT 6.1; WOW64; rv:36.0) Gecko/20100101 Firefox/36.0");
        }

        private void ProductHelperForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            lblSite.Text = "Displaying Products For: " + Site.SiteName;
        }

        public void LoadProducts()
        {
            _http.IncludeHeaderInResponse = false;
            var response = _http.Get(Site.ProductsJson);
            if (string.IsNullOrEmpty(response))
            {
                MessageBox.Show("Error downloading products file. Site down?");
                return;
            }
            JObject productsJson;
            try
            {
                productsJson = JObject.Parse(response);
            }
            catch
            {
                MessageBox.Show("Failed to pass JSON. Site timeout?");
                return;
            }
            foreach (var product in productsJson["products"])
            {
                TreeNode parent = new TreeNode((string)product["title"]);
                var id = new TreeNode("ID: " + (string) product["id"]);
                parent.Nodes.Add(id);

                var link = new TreeNode("Early Link: " + Site.ProductsJson.Replace("products.json", "products/") + (string) product["handle"]);
                parent.Nodes.Add(link);

                var skus = new TreeNode("Sizes");
                parent.Nodes.Add(skus);

                foreach (var sizes in product["variants"])
                {
                    var sizeParent = new TreeNode((string) sizes["title"]);
                    var sizeId = new TreeNode("Size ID: " + (string) sizes["id"]);
                    sizeParent.Nodes.Add(sizeId);
                    var skuId = new TreeNode((string) sizes["sku"]);
                    sizeParent.Nodes.Add(skuId);
                    var price = new TreeNode((string) sizes["price"]);
                    sizeParent.Nodes.Add(price);
                    var instock = new TreeNode("Available: " + (string) sizes["available"]);
                    sizeParent.Nodes.Add(instock);
                    skus.Nodes.Add(sizeParent);
                }
                ProductsTree.Nodes.Add(parent);
            }
        }

        private void ProductsTree_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = ProductsTree.SelectedNode;
            while (node.Parent != null)
            {
                node = node.Parent;
            } 
            form.SetProduct(node.Text);
            Close();
        }

        private void ProductsTree_Click(object sender, EventArgs e)
        {
   
        }

        private void ProductsTree_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode node = ProductsTree.SelectedNode;
                while (node.Parent != null)
                {
                    node = node.Parent;
                }
                Clipboard.SetText(node.Nodes[1].Text);
                MessageBox.Show("Early Link copied to clipboard");
            }
        }
    }
}
