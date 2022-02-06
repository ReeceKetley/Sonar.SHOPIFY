using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
using SonarSUPREME.General_Classes;

namespace SonarSUPREME.Supreme_Classes
{
    public partial class EditJsonForm : MetroForm
    {
        private string File;
        private string OriganalFile;
        public EditJsonForm(string file)
        {
            InitializeComponent();
            File = file;
        }

        private void EditJsonForm_Load(object sender, EventArgs e)
        {
            OriganalFile = System.IO.File.ReadAllText(File);
            textBox1.Text = OriganalFile;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                JArray arr = JArray.Parse(textBox1.Text.Trim());
            }
            catch
            {
                MessageBox.Show("JSON Validation failed. Check for trailing characters. File has not been updated");
                return;
            }
            System.IO.File.Delete(File);
            System.IO.File.WriteAllText(File, textBox1.Text.Trim());
            MessageBox.Show("File passed validation and has been saved.");
            SharedData.BillingInfos.Clear();
            SharedData.LoadBillingInfo();
            Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = OriganalFile;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
