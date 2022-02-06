namespace SonarMULTI.Supreme_Classes
{
    partial class SupremeMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupremeMain));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txtLog = new MetroFramework.Controls.MetroTextBox();
            this.olvTasks = new BrightIdeasSoftware.ObjectListView();
            this.olvID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvSite = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvKeyword = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvBillingProfile = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvProxy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1155, 483);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.txtLog);
            this.metroTabPage1.Controls.Add(this.olvTasks);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1147, 441);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Status";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // txtLog
            // 
            this.txtLog.Lines = new string[] {
        "Click a task to see its full status report"};
            this.txtLog.Location = new System.Drawing.Point(4, 337);
            this.txtLog.MaxLength = 32767;
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.PasswordChar = '\0';
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.SelectedText = "";
            this.txtLog.Size = new System.Drawing.Size(1140, 108);
            this.txtLog.TabIndex = 3;
            this.txtLog.Text = "Click a task to see its full status report";
            this.txtLog.UseSelectable = true;
            // 
            // olvTasks
            // 
            this.olvTasks.AllColumns.Add(this.olvID);
            this.olvTasks.AllColumns.Add(this.olvSite);
            this.olvTasks.AllColumns.Add(this.olvKeyword);
            this.olvTasks.AllColumns.Add(this.olvSize);
            this.olvTasks.AllColumns.Add(this.olvBillingProfile);
            this.olvTasks.AllColumns.Add(this.olvProxy);
            this.olvTasks.AllColumns.Add(this.olvStatus);
            this.olvTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvID,
            this.olvSite,
            this.olvKeyword,
            this.olvSize,
            this.olvBillingProfile,
            this.olvProxy,
            this.olvStatus});
            this.olvTasks.FullRowSelect = true;
            this.olvTasks.Location = new System.Drawing.Point(4, 4);
            this.olvTasks.Name = "olvTasks";
            this.olvTasks.ShowGroups = false;
            this.olvTasks.Size = new System.Drawing.Size(1143, 326);
            this.olvTasks.TabIndex = 2;
            this.olvTasks.UseCompatibleStateImageBehavior = false;
            this.olvTasks.View = System.Windows.Forms.View.Details;
            this.olvTasks.SelectedIndexChanged += new System.EventHandler(this.olvTasks_SelectedIndexChanged);
            this.olvTasks.DoubleClick += new System.EventHandler(this.olvTasks_DoubleClick);
            // 
            // olvID
            // 
            this.olvID.AspectName = "olvID";
            this.olvID.CellPadding = null;
            this.olvID.Text = "ID";
            this.olvID.Width = 45;
            // 
            // olvSite
            // 
            this.olvSite.CellPadding = null;
            this.olvSite.Text = "Site";
            this.olvSite.Width = 74;
            // 
            // olvKeyword
            // 
            this.olvKeyword.AspectName = "olvKeyword";
            this.olvKeyword.CellPadding = null;
            this.olvKeyword.Text = "Product Keyword String";
            this.olvKeyword.Width = 133;
            // 
            // olvSize
            // 
            this.olvSize.AspectName = "olvSize";
            this.olvSize.CellPadding = null;
            this.olvSize.Text = "Size Keyword";
            this.olvSize.Width = 84;
            // 
            // olvBillingProfile
            // 
            this.olvBillingProfile.AspectName = "olvBillingProfile";
            this.olvBillingProfile.CellPadding = null;
            this.olvBillingProfile.Text = "Billing Profile";
            this.olvBillingProfile.Width = 95;
            // 
            // olvProxy
            // 
            this.olvProxy.AspectName = "olvProxy";
            this.olvProxy.CellPadding = null;
            this.olvProxy.Text = "Proxy";
            this.olvProxy.Width = 135;
            // 
            // olvStatus
            // 
            this.olvStatus.AspectName = "olvStatus";
            this.olvStatus.CellPadding = null;
            this.olvStatus.Text = "Status";
            this.olvStatus.Width = 570;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(830, 73);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(110, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Delete Tasks";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(946, 73);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(110, 23);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Create Task";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(1062, 73);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(113, 23);
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "Start/Stop Tasks";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            this.metroButton3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroButton3_MouseClick);
            this.metroButton3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.metroButton3_MouseUp);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(598, 73);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(110, 23);
            this.metroButton5.TabIndex = 7;
            this.metroButton5.Text = "Proxies";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(714, 73);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(110, 23);
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = "Billing Info";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(482, 73);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(110, 23);
            this.metroButton6.TabIndex = 8;
            this.metroButton6.Text = "Custom Sites";
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // SupremeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 570);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupremeMain";
            this.Resizable = false;
            this.Text = "SonarSHOPIFY";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SupremeMain_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private BrightIdeasSoftware.ObjectListView olvTasks;
        private BrightIdeasSoftware.OLVColumn olvID;
        private BrightIdeasSoftware.OLVColumn olvKeyword;
        private BrightIdeasSoftware.OLVColumn olvSize;
        private BrightIdeasSoftware.OLVColumn olvProxy;
        private BrightIdeasSoftware.OLVColumn olvStatus;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private BrightIdeasSoftware.OLVColumn olvBillingProfile;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton4;
        private BrightIdeasSoftware.OLVColumn olvSite;
        private MetroFramework.Controls.MetroTextBox txtLog;
        private MetroFramework.Controls.MetroButton metroButton6;
    }
}