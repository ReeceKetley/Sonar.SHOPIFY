namespace SonarRESTOCK.Forms
{
    partial class BillingInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingInfoForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtCVV = new MetroFramework.Controls.MetroTextBox();
            this.txtExpiry = new MetroFramework.Controls.MetroTextBox();
            this.txtCardNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTelephone = new MetroFramework.Controls.MetroTextBox();
            this.txtZipOrPostalCode = new MetroFramework.Controls.MetroTextBox();
            this.txtCity = new MetroFramework.Controls.MetroTextBox();
            this.txtBillingAddress3 = new MetroFramework.Controls.MetroTextBox();
            this.txtBillingAddress2 = new MetroFramework.Controls.MetroTextBox();
            this.txtBillingAddress1 = new MetroFramework.Controls.MetroTextBox();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.txtCardName = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.txtCardName);
            this.groupBox2.Controls.Add(this.metroComboBox1);
            this.groupBox2.Controls.Add(this.metroButton1);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtCVV);
            this.groupBox2.Controls.Add(this.txtExpiry);
            this.groupBox2.Controls.Add(this.txtCardNumber);
            this.groupBox2.Controls.Add(this.metroComboBox3);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.txtTelephone);
            this.groupBox2.Controls.Add(this.txtZipOrPostalCode);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(this.txtBillingAddress3);
            this.groupBox2.Controls.Add(this.txtBillingAddress2);
            this.groupBox2.Controls.Add(this.txtBillingAddress1);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.metroButton5);
            this.groupBox2.Controls.Add(this.metroButton6);
            this.groupBox2.Controls.Add(this.metroComboBox2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(23, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 391);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Billing Profiles";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(5, 226);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.PromptText = "State";
            this.metroComboBox1.Size = new System.Drawing.Size(616, 29);
            this.metroComboBox1.TabIndex = 20;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(477, 19);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(143, 29);
            this.metroButton1.TabIndex = 19;
            this.metroButton1.Text = "Edit File (Advanced)";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(6, 83);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Email";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(614, 23);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtEmail.UseSelectable = true;
            // 
            // txtCVV
            // 
            this.txtCVV.Lines = new string[0];
            this.txtCVV.Location = new System.Drawing.Point(314, 359);
            this.txtCVV.MaxLength = 32767;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.PasswordChar = '\0';
            this.txtCVV.PromptText = "CVV";
            this.txtCVV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCVV.SelectedText = "";
            this.txtCVV.Size = new System.Drawing.Size(306, 23);
            this.txtCVV.TabIndex = 17;
            this.txtCVV.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCVV.UseSelectable = true;
            // 
            // txtExpiry
            // 
            this.txtExpiry.Lines = new string[0];
            this.txtExpiry.Location = new System.Drawing.Point(134, 359);
            this.txtExpiry.MaxLength = 32767;
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.PasswordChar = '\0';
            this.txtExpiry.PromptText = "Expiry (00/00)";
            this.txtExpiry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExpiry.SelectedText = "";
            this.txtExpiry.Size = new System.Drawing.Size(175, 23);
            this.txtExpiry.TabIndex = 16;
            this.txtExpiry.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtExpiry.UseSelectable = true;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Lines = new string[0];
            this.txtCardNumber.Location = new System.Drawing.Point(133, 330);
            this.txtCardNumber.MaxLength = 32767;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.PasswordChar = '\0';
            this.txtCardNumber.PromptText = "Card Number";
            this.txtCardNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCardNumber.SelectedText = "";
            this.txtCardNumber.Size = new System.Drawing.Size(487, 23);
            this.txtCardNumber.TabIndex = 15;
            this.txtCardNumber.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCardNumber.UseSelectable = true;
            this.txtCardNumber.TextChanged += new System.EventHandler(this.txtCardNumber_TextChanged);
            this.txtCardNumber.Click += new System.EventHandler(this.txtCardNumber_Click);
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Items.AddRange(new object[] {
            "Visa",
            "MasterCard",
            "AmericanExpress",
            "Solo"});
            this.metroComboBox3.Location = new System.Drawing.Point(6, 299);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.PromptText = "Card Type";
            this.metroComboBox3.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox3.TabIndex = 14;
            this.metroComboBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox3.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(6, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 3);
            this.panel1.TabIndex = 13;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Lines = new string[0];
            this.txtTelephone.Location = new System.Drawing.Point(314, 259);
            this.txtTelephone.MaxLength = 32767;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.PasswordChar = '\0';
            this.txtTelephone.PromptText = "Contact Number";
            this.txtTelephone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelephone.SelectedText = "";
            this.txtTelephone.Size = new System.Drawing.Size(306, 23);
            this.txtTelephone.TabIndex = 12;
            this.txtTelephone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTelephone.UseSelectable = true;
            // 
            // txtZipOrPostalCode
            // 
            this.txtZipOrPostalCode.Lines = new string[0];
            this.txtZipOrPostalCode.Location = new System.Drawing.Point(6, 259);
            this.txtZipOrPostalCode.MaxLength = 32767;
            this.txtZipOrPostalCode.Name = "txtZipOrPostalCode";
            this.txtZipOrPostalCode.PasswordChar = '\0';
            this.txtZipOrPostalCode.PromptText = "Zip/Postcode";
            this.txtZipOrPostalCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtZipOrPostalCode.SelectedText = "";
            this.txtZipOrPostalCode.Size = new System.Drawing.Size(302, 23);
            this.txtZipOrPostalCode.TabIndex = 11;
            this.txtZipOrPostalCode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtZipOrPostalCode.UseSelectable = true;
            // 
            // txtCity
            // 
            this.txtCity.Lines = new string[0];
            this.txtCity.Location = new System.Drawing.Point(6, 200);
            this.txtCity.MaxLength = 32767;
            this.txtCity.Name = "txtCity";
            this.txtCity.PasswordChar = '\0';
            this.txtCity.PromptText = "City";
            this.txtCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCity.SelectedText = "";
            this.txtCity.Size = new System.Drawing.Size(614, 23);
            this.txtCity.TabIndex = 9;
            this.txtCity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCity.UseSelectable = true;
            // 
            // txtBillingAddress3
            // 
            this.txtBillingAddress3.Lines = new string[0];
            this.txtBillingAddress3.Location = new System.Drawing.Point(6, 171);
            this.txtBillingAddress3.MaxLength = 32767;
            this.txtBillingAddress3.Name = "txtBillingAddress3";
            this.txtBillingAddress3.PasswordChar = '\0';
            this.txtBillingAddress3.PromptText = "Billing Address Line 3";
            this.txtBillingAddress3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBillingAddress3.SelectedText = "";
            this.txtBillingAddress3.Size = new System.Drawing.Size(614, 23);
            this.txtBillingAddress3.TabIndex = 8;
            this.txtBillingAddress3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBillingAddress3.UseSelectable = true;
            // 
            // txtBillingAddress2
            // 
            this.txtBillingAddress2.Lines = new string[0];
            this.txtBillingAddress2.Location = new System.Drawing.Point(6, 141);
            this.txtBillingAddress2.MaxLength = 32767;
            this.txtBillingAddress2.Name = "txtBillingAddress2";
            this.txtBillingAddress2.PasswordChar = '\0';
            this.txtBillingAddress2.PromptText = "Billing Address Line 2";
            this.txtBillingAddress2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBillingAddress2.SelectedText = "";
            this.txtBillingAddress2.Size = new System.Drawing.Size(614, 23);
            this.txtBillingAddress2.TabIndex = 7;
            this.txtBillingAddress2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBillingAddress2.UseSelectable = true;
            // 
            // txtBillingAddress1
            // 
            this.txtBillingAddress1.Lines = new string[0];
            this.txtBillingAddress1.Location = new System.Drawing.Point(7, 112);
            this.txtBillingAddress1.MaxLength = 32767;
            this.txtBillingAddress1.Name = "txtBillingAddress1";
            this.txtBillingAddress1.PasswordChar = '\0';
            this.txtBillingAddress1.PromptText = "Billing Address Line 1";
            this.txtBillingAddress1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBillingAddress1.SelectedText = "";
            this.txtBillingAddress1.Size = new System.Drawing.Size(614, 23);
            this.txtBillingAddress1.TabIndex = 6;
            this.txtBillingAddress1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBillingAddress1.UseSelectable = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Lines = new string[0];
            this.txtLastName.Location = new System.Drawing.Point(315, 54);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PromptText = "Last name";
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(306, 23);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtLastName.UseSelectable = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Lines = new string[0];
            this.txtFirstName.Location = new System.Drawing.Point(7, 54);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PromptText = "First name";
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(302, 23);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtFirstName.UseSelectable = true;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(315, 19);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(75, 29);
            this.metroButton5.TabIndex = 2;
            this.metroButton5.Text = "Add";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(396, 19);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(75, 29);
            this.metroButton6.TabIndex = 1;
            this.metroButton6.Text = "Delete";
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(7, 19);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.PromptText = "Billing Profile";
            this.metroComboBox2.Size = new System.Drawing.Size(302, 29);
            this.metroComboBox2.TabIndex = 0;
            this.metroComboBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox2.UseSelectable = true;
            // 
            // txtCardName
            // 
            this.txtCardName.Lines = new string[0];
            this.txtCardName.Location = new System.Drawing.Point(133, 301);
            this.txtCardName.MaxLength = 32767;
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.PasswordChar = '\0';
            this.txtCardName.PromptText = "Name on card";
            this.txtCardName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCardName.SelectedText = "";
            this.txtCardName.Size = new System.Drawing.Size(487, 23);
            this.txtCardName.TabIndex = 21;
            this.txtCardName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCardName.UseSelectable = true;
            // 
            // BillingInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 469);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillingInfoForm";
            this.Resizable = false;
            this.Text = "Billing Profiles";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtCVV;
        private MetroFramework.Controls.MetroTextBox txtExpiry;
        private MetroFramework.Controls.MetroTextBox txtCardNumber;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txtTelephone;
        private MetroFramework.Controls.MetroTextBox txtZipOrPostalCode;
        private MetroFramework.Controls.MetroTextBox txtCity;
        private MetroFramework.Controls.MetroTextBox txtBillingAddress3;
        private MetroFramework.Controls.MetroTextBox txtBillingAddress2;
        private MetroFramework.Controls.MetroTextBox txtBillingAddress1;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox txtCardName;
    }
}