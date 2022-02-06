namespace SonarSHOPIFY
{
    partial class ProductHelperForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductsTree = new System.Windows.Forms.TreeView();
            this.lblSite = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // ProductsTree
            // 
            this.ProductsTree.Location = new System.Drawing.Point(19, 84);
            this.ProductsTree.Name = "ProductsTree";
            this.ProductsTree.Size = new System.Drawing.Size(934, 419);
            this.ProductsTree.TabIndex = 0;
            this.ProductsTree.Click += new System.EventHandler(this.ProductsTree_Click);
            this.ProductsTree.DoubleClick += new System.EventHandler(this.ProductsTree_DoubleClick);
            this.ProductsTree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductsTree_MouseClick);
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(15, 59);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(154, 19);
            this.lblSite.TabIndex = 1;
            this.lblSite.Text = "Displaying Products For: ";
            this.lblSite.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ProductHelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 522);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.ProductsTree);
            this.Name = "ProductHelperForm";
            this.Text = "Product Picker";
            this.Load += new System.EventHandler(this.ProductHelperForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView ProductsTree;
        private MetroFramework.Controls.MetroLabel lblSite;
    }
}