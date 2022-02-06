namespace SonarMULTI.Supreme_Classes
{
    partial class CreateTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTask));
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtKeyword = new MetroFramework.Controls.MetroTextBox();
            this.txtSKU = new MetroFramework.Controls.MetroTextBox();
            this.tglFindBySku = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtSizeKeyword = new MetroFramework.Controls.MetroTextBox();
            this.tglAutoCheckout = new MetroFramework.Controls.MetroToggle();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblSite = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(24, 357);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.PromptText = "Proxy (blank for no proxy)";
            this.metroComboBox1.Size = new System.Drawing.Size(604, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(24, 392);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.PromptText = "Billing Profile";
            this.metroComboBox2.Size = new System.Drawing.Size(435, 29);
            this.metroComboBox2.TabIndex = 3;
            this.metroComboBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(247, 427);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(157, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Create";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.metroTile1);
            this.flowLayoutPanel1.Controls.Add(this.metroTile2);
            this.flowLayoutPanel1.Controls.Add(this.metroTile3);
            this.flowLayoutPanel1.Controls.Add(this.metroTile4);
            this.flowLayoutPanel1.Controls.Add(this.metroTile5);
            this.flowLayoutPanel1.Controls.Add(this.metroTile6);
            this.flowLayoutPanel1.Controls.Add(this.metroTile7);
            this.flowLayoutPanel1.Controls.Add(this.metroTile8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(604, 172);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Select Site";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Lines = new string[0];
            this.txtKeyword.Location = new System.Drawing.Point(23, 268);
            this.txtKeyword.MaxLength = 32767;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.PasswordChar = '\0';
            this.txtKeyword.PromptText = "Keyword e.g Jordan 7";
            this.txtKeyword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKeyword.SelectedText = "";
            this.txtKeyword.Size = new System.Drawing.Size(605, 23);
            this.txtKeyword.TabIndex = 7;
            this.txtKeyword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtKeyword.UseSelectable = true;
            // 
            // txtSKU
            // 
            this.txtSKU.Lines = new string[0];
            this.txtSKU.Location = new System.Drawing.Point(23, 328);
            this.txtSKU.MaxLength = 32767;
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.PasswordChar = '\0';
            this.txtSKU.PromptText = "SKU Code (Opt)";
            this.txtSKU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSKU.SelectedText = "";
            this.txtSKU.Size = new System.Drawing.Size(436, 23);
            this.txtSKU.TabIndex = 8;
            this.txtSKU.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSKU.UseSelectable = true;
            // 
            // tglFindBySku
            // 
            this.tglFindBySku.AutoSize = true;
            this.tglFindBySku.Location = new System.Drawing.Point(548, 331);
            this.tglFindBySku.Name = "tglFindBySku";
            this.tglFindBySku.Size = new System.Drawing.Size(80, 17);
            this.tglFindBySku.TabIndex = 9;
            this.tglFindBySku.Text = "Off";
            this.tglFindBySku.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tglFindBySku.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(460, 330);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Find By SKU:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtSizeKeyword
            // 
            this.txtSizeKeyword.Lines = new string[0];
            this.txtSizeKeyword.Location = new System.Drawing.Point(23, 298);
            this.txtSizeKeyword.MaxLength = 32767;
            this.txtSizeKeyword.Name = "txtSizeKeyword";
            this.txtSizeKeyword.PasswordChar = '\0';
            this.txtSizeKeyword.PromptText = "Size Keyword";
            this.txtSizeKeyword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSizeKeyword.SelectedText = "";
            this.txtSizeKeyword.Size = new System.Drawing.Size(605, 23);
            this.txtSizeKeyword.TabIndex = 11;
            this.txtSizeKeyword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSizeKeyword.UseSelectable = true;
            // 
            // tglAutoCheckout
            // 
            this.tglAutoCheckout.AutoSize = true;
            this.tglAutoCheckout.Location = new System.Drawing.Point(548, 398);
            this.tglAutoCheckout.Name = "tglAutoCheckout";
            this.tglAutoCheckout.Size = new System.Drawing.Size(80, 17);
            this.tglAutoCheckout.TabIndex = 12;
            this.tglAutoCheckout.Text = "Off";
            this.tglAutoCheckout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tglAutoCheckout.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(460, 396);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "AutoCheckout";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(20, 244);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(114, 19);
            this.lblSite.TabIndex = 14;
            this.lblSite.Text = "Selected Site: N/A";
            this.lblSite.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(518, 244);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(110, 23);
            this.metroButton2.TabIndex = 15;
            this.metroButton2.Text = "Product Picker";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(145, 80);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "KB24";
            this.metroTile1.TileImage = global::SonarSHOPIFY.Properties.Resources.Untitled;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(154, 3);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(145, 80);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "KithNYC";
            this.metroTile2.TileImage = global::SonarSHOPIFY.Properties.Resources.logo1;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(305, 3);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(145, 80);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Packer Shoes";
            this.metroTile3.TileImage = global::SonarSHOPIFY.Properties.Resources.logo2;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(456, 3);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(145, 80);
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "Concepts";
            this.metroTile4.TileImage = global::SonarSHOPIFY.Properties.Resources.Untitled2;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(3, 89);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(145, 80);
            this.metroTile5.TabIndex = 4;
            this.metroTile5.Text = "Supplied";
            this.metroTile5.TileImage = global::SonarSHOPIFY.Properties.Resources.logo3;
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(154, 89);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(145, 80);
            this.metroTile6.TabIndex = 5;
            this.metroTile6.Text = "ShopNiceKicks";
            this.metroTile6.TileImage = global::SonarSHOPIFY.Properties.Resources.logo4;
            this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.UseTileImage = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Location = new System.Drawing.Point(305, 89);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(145, 80);
            this.metroTile7.TabIndex = 6;
            this.metroTile7.Text = "Livestock (deadstock)";
            this.metroTile7.TileImage = global::SonarSHOPIFY.Properties.Resources.logo5;
            this.metroTile7.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile7.UseSelectable = true;
            this.metroTile7.UseTileImage = true;
            this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.metroTile8.Location = new System.Drawing.Point(456, 89);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(145, 80);
            this.metroTile8.TabIndex = 7;
            this.metroTile8.Text = "BB Branded";
            this.metroTile8.TileImage = global::SonarSHOPIFY.Properties.Resources.Untitled3;
            this.metroTile8.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile8.UseSelectable = true;
            this.metroTile8.UseTileImage = true;
            this.metroTile8.Click += new System.EventHandler(this.metroTile8_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(402, 244);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(110, 23);
            this.metroButton3.TabIndex = 16;
            this.metroButton3.Text = "Custom Sites";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(635, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 342);
            this.listBox1.TabIndex = 17;
            this.listBox1.Visible = false;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 473);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tglAutoCheckout);
            this.Controls.Add(this.txtSizeKeyword);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tglFindBySku);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTask";
            this.Resizable = false;
            this.Text = "Create Task";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.CreateTask_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTextBox txtKeyword;
        private MetroFramework.Controls.MetroTextBox txtSKU;
        private MetroFramework.Controls.MetroToggle tglFindBySku;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtSizeKeyword;
        private MetroFramework.Controls.MetroToggle tglAutoCheckout;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblSite;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.ListBox listBox1;

    }
}