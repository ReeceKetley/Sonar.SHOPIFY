namespace SonarSHOPIFY.Bot_Classes
{
    partial class CheckoutCompleteForm
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
            this.wc = new EO.WebBrowser.WinForm.WebControl();
            this.webView1 = new EO.WebBrowser.WebView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wc
            // 
            this.wc.BackColor = System.Drawing.Color.White;
            this.wc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wc.Location = new System.Drawing.Point(0, 0);
            this.wc.Name = "wc";
            this.wc.Size = new System.Drawing.Size(1017, 262);
            this.wc.TabIndex = 0;
            this.wc.Text = "webControl1";
            this.wc.WebView = this.webView1;
            this.wc.Click += new System.EventHandler(this.wc_Click);
            // 
            // webView1
            // 
            this.webView1.AllowDropLoad = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(921, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckoutCompleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wc);
            this.Name = "CheckoutCompleteForm";
            this.Text = "CheckoutCompleteForm";
            this.Load += new System.EventHandler(this.CheckoutCompleteForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private EO.WebBrowser.WinForm.WebControl wc;
        private EO.WebBrowser.WebView webView1;
        private System.Windows.Forms.Button button1;
    }
}