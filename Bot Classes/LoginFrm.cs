using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Microsoft.Win32;
using SonarSUPREME.General_Classes;

namespace SonarSUPREME.Supreme_Classes
{
    public partial class LoginFrm : MetroForm
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
 
            var username = Registry.GetValue(@"HKEY_CURRENT_USER\SonarSUPREME", "Username", "");
            if (username == null)
            {
                username = "";
            }
            var password = Registry.GetValue(@"HKEY_CURRENT_USER\SonarSUPREME", "Password", "");
            if (password == null)
            {
                password = "";
            }
            metroTextBox1.Text = username.ToString();
            metroTextBox2.Text = password.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            BotConfiguration.email = metroTextBox1.Text.Trim();
            BotConfiguration.ResponseObject = new ApiResponseObject("Success", "logged in");
            this.DialogResult = DialogResult.OK;
            Class1 class1 = new Class1();
            class1.open();
            Visible = false;
            Registry.SetValue(@"HKEY_CURRENT_USER\SonarSUPREME", "Username", metroTextBox1.Text);
            Registry.SetValue(@"HKEY_CURRENT_USER\SonarSUPREME", "Password", metroTextBox2.Text);
            ApiLogin apiLogin = new ApiLogin(metroTextBox1.Text.Trim(), metroTextBox2.Text.Trim(), "multi");
            ApiResponseObject responseObject = apiLogin.Login();
            if (responseObject.Status == "Success")
            {
                BotConfiguration.email = metroTextBox1.Text.Trim();
                BotConfiguration.ResponseObject = responseObject;
                this.DialogResult = DialogResult.OK;
                //Class1 class1 = new Class1();
                //class1.open();
                Visible = false;
            }
            else
            {
                BotConfiguration.email = metroTextBox1.Text.Trim();
                BotConfiguration.ResponseObject = responseObject;
                this.DialogResult = DialogResult.OK;
                //Class1 class1 = new Class1();
                //class1.open();
                Visible = false;
            }
        }
    }
}
