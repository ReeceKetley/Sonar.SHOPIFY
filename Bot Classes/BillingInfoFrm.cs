using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using SonarSUPREME;
using SonarSUPREME.General_Classes;
using SonarSUPREME.Supreme_Classes;

namespace SonarRESTOCK.Forms
{
    public partial class BillingInfoForm : MetroForm
    {
        public BillingInfoForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SharedData.LoadBillingInfo();
            foreach (var state in StatesClass.States)
            {
                metroComboBox1.Items.Add(state.Title);
            }
            foreach (var billingInfo in SharedData.BillingInfos)
            {
                metroComboBox2.Items.Add(billingInfo.FullName);
            }
        }



        private bool isValid(string text)
        {
            return !string.IsNullOrEmpty(text);
        }


        private string Group4(string s)
        {
            string output = "";
            for (int i = 0; i < s.Length; i += 4)
                output += s.Substring(i, 4) + ' ';

            return s.TrimEnd();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            try
            {
                var cardNumber = txtCardNumber.Text;
                var expiry = txtExpiry.Text.Split('/');
                BillingInfo billingInfo = new BillingInfo(txtFirstName.Text, txtLastName.Text, "08/02/88",
                    txtTelephone.Text, txtEmail.Text, txtBillingAddress1.Text.Split(' ')[0].Trim(),
                    txtBillingAddress1.Text, txtBillingAddress2.Text, txtBillingAddress3.Text, txtCity.Text,
                    txtZipOrPostalCode.Text, metroComboBox1.SelectedItem.ToString(), "United States",
                    metroComboBox3.SelectedItem.ToString(), txtCardName.Text,
                    cardNumber, expiry[0], expiry[1], txtCVV.Text.Trim());
                SharedData.BillingInfos.Add(billingInfo);
                SharedData.SaveBillingInfo();
                metroComboBox2.Items.Add(billingInfo.FullName);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
                
            }
            MessageBox.Show("Billing Profile added.");
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            var selectedItem = metroComboBox2.SelectedItem;
            if (!string.IsNullOrEmpty(selectedItem.ToString()))
            {
                foreach (var billingInfo in SharedData.BillingInfos.ToList())
                {
                    if (billingInfo.FullName == selectedItem.ToString())
                    {
                        metroComboBox2.Items.Remove(selectedItem);
                        SharedData.BillingInfos.Remove(billingInfo);
                        SharedData.SaveBillingInfo();
                    }
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            EditJsonForm frm = new EditJsonForm("Billing.json");
            frm.ShowDialog();
            metroComboBox2.Items.Clear();
            foreach (var billingInfo in SharedData.BillingInfos)
            {
                metroComboBox2.Items.Add(billingInfo.FullName);
            }
        }

        private void txtStateCounty_Click(object sender, EventArgs e)
        {

        }

        private void txtCardNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtCardNumber.Text.Length == 4)
            {
                txtCardNumber.AppendText(" ");
            }
            if (txtCardNumber.Text.Length == 9)
            {
                txtCardNumber.AppendText(" ");
            }
            if (txtCardNumber.Text.Length == 14)
            {
                txtCardNumber.AppendText(" ");
            }

        }


    }
}
