using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MetroFramework.Forms;
using SonarSUPREME.General_Classes;

namespace SonarSUPREME.Supreme_Classes
{
    public partial class ProxiesFrm : MetroForm
    {
        public ProxiesFrm()
        {
            InitializeComponent();
        }

        private void ProxiesFrm_Load(object sender, EventArgs e)
        {
            foreach (var proxy in SharedData.Proxies)
            {
                listBox1.Items.Add(proxy.ProxyString);
            }
        }

        public static bool ValidateProxy(string input)
        {
            string pattern = @"\A\d{1,3}(\.\d{1,3}){3}:\d{1,5}\z";
            Match match = Regex.Match(input, pattern);
            return match.Success;
        }

        public static bool IsValidProxyCredential(string input)
        {
            string[] chunks = input.Split(':');
            if (chunks.Length == 2 || chunks.Length == 4)
            {
                string proxy = chunks[0] + ":" + chunks[1];

                if (ValidateProxy(proxy))
                {
                    if (chunks.Length == 4 && (chunks[2].Length < 1 || chunks[3].Length < 1))
                    {
                        return false;
                    }
                    return true;
                }
            }
            return false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var proxyString = metroTextBox1.Text.Trim();
            if (!IsValidProxyCredential(proxyString))
            {
                MessageBox.Show("Proxy is invalid");
                return;
            }
            SharedData.Proxies.Add(new Proxy(proxyString));
            SharedData.SaveProxies();
            listBox1.Items.Add(proxyString);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var items = listBox1.SelectedItems.OfType<string>().ToList();
            if (items.Count < 0)
            {
                return;
            }
            foreach (var selectedItem in items)
            {
                foreach (var proxy in SharedData.Proxies.ToList())
                {
                    if (proxy.ProxyString.Contains(selectedItem.ToString()))
                    {
                        SharedData.Proxies.Remove(proxy);
                        listBox1.Items.Remove(selectedItem);
                    }
                }
            }
            SharedData.SaveProxies();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var file = openFileDialog1.FileName;
            if (string.IsNullOrEmpty(file))
            {
                return;
            }
            var txt = File.ReadAllText(file);
            var line = txt.Split('\n');
            foreach (var s in line)
            {
                if (IsValidProxyCredential(s))
                {
                    SharedData.Proxies.Add(new Proxy(s));
                    listBox1.Items.Add(s);
                }
            }
            SharedData.SaveProxies();
        }

    }
}
