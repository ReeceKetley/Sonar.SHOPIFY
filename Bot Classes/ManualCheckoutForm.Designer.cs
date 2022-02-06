namespace SonarSHOPIFY.Bot_Classes
{
    partial class ManualCheckoutForm
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
            this.webView1 = new EO.WebBrowser.WebView();
            this.wb = new EO.WebBrowser.WinForm.WebControl();
            this.webView2 = new EO.WebBrowser.WebView();
            this.SuspendLayout();
            // 
            // webView1
            // 
            this.webView1.AllowDropLoad = true;
            // 
            // wb
            // 
            this.wb.BackColor = System.Drawing.Color.White;
            this.wb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb.Location = new System.Drawing.Point(16, 60);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(1030, 582);
            this.wb.TabIndex = 0;
            this.wb.WebView = this.webView2;
            // 
            // webView2
            // 
            this.webView2.AllowDropLoad = true;
            // 
            // ManualCheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 658);
            this.Controls.Add(this.wb);
            this.Name = "ManualCheckoutForm";
            this.Text = "Manual Checkout - ";
            this.Load += new System.EventHandler(this.ManualCheckoutForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private EO.WebBrowser.WebView webView1;
        private EO.WebBrowser.WinForm.WebControl wb;
        private EO.WebBrowser.WebView webView2;
    }
}