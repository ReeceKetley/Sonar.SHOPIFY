using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Newtonsoft.Json.Linq;
using SonarRESTOCK;

namespace SonarSUPREME.General_Classes
{
    public static class EmailSender
    {
        public static string host = "";
        public static string port = "";
        public static string pass = "";
        public static string subject = "";
        public static string from = "";
        public static bool useSSL = false;
        public static bool useCustom;
        public static string smtpuser = "";

        static EmailSender()
        {
            //LoadSettings();
        }
        public static void SendMailViaPost(string to, string product, string size, string alert, string subject1, string email = "1")
        {
            Debug.WriteLine("Cakked send via post");
            HTTP http = new HTTP("");
            try
            {
                if (email == "0")
                {
                    var number = to.Split('@')[0];
                    if (number[0].ToString() != "1") ;
                    {
                        number = "1" + number;
                    }

                    SendSMS(number, product, size, alert);
                    return;
                }
            }
            catch
            {

            }
            string postData = "{" + "\"to\": \"" + to + "\", \"product\": \"" + product + "\", \"size\": \"" + size + "\", \"alert\": \"" + alert + "\", \"subject\": \"" + subject1 + "\", \"salt\": \"" + Functions.RandomString(50) + "\"" + "}";
            postData = Encrypt(postData);
            //Debug.WriteLine(postData);
            var result = http.Post("http://mg.nikesonar.com/restock.php", "to=" + HttpUtility.UrlEncode(to) + "&subject=" + HttpUtility.UrlEncode(subject1) + "&alert=" + HttpUtility.UrlEncode(alert) + "&email=" + HttpUtility.UrlEncode(email) + "&u=" + HttpUtility.UrlEncode(BotConfiguration.CurrentApiUser.Username) + "&p=" + HttpUtility.UrlEncode(BotConfiguration.CurrentApiUser.Password));
            Debug.WriteLine(result);
        }

        public static void SendSMS(string to, string product, string size, string alert)
        {
            var msg = HttpUtility.UrlEncode("SonarSUPREME Alert: " + alert);
            HTTP http = new HTTP("");
            var result = http.Post("http://mg.nikesonar.com/sms.php", "to=" + HttpUtility.UrlEncode(to) + "&msg=" + msg + "&u=" + HttpUtility.UrlEncode(BotConfiguration.CurrentApiUser.Username) + "&p=" + HttpUtility.UrlEncode(BotConfiguration.CurrentApiUser.Password));
            Debug.WriteLine(result);
        }

        static void LoadSettings()
        {
            JObject settings = JObject.Parse(AES.Decrypt(File.ReadAllText("settings.json")));
            host = (string) settings["host"];
            pass = (string) settings["pass"];
            smtpuser = (string) settings["user"];
            from = (string) settings["from"];
            port = (string) settings["port"];
            subject = (string) settings["subject"];
            useSSL = (bool) settings["ssl"];
            if (string.IsNullOrEmpty(host) || string.IsNullOrEmpty(smtpuser))
            {
                useCustom = false;
            }
        }
        public static bool SendM(string to_email, string to_name, string body, out string errorMessage, bool bIsBodyHTML = true)
        {
            Debug.WriteLine("Sending mail: " + to_email);
            errorMessage = "";
           // try
            //{
                MailAddress ifrom = new MailAddress(from, from);
                MailAddress to = new MailAddress(to_email, to_name);
                SmtpClient client = new SmtpClient
                {
                    Host = host,
                    Port = Convert.ToInt32(port),
                    EnableSsl = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(smtpuser, pass)
                };
                MailMessage message2 = new MailMessage(ifrom, to)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = bIsBodyHTML
                };
                using (MailMessage message = message2)
                {
                    client.Send(message);
                }
                return true;
            //}
            //catch (Exception e)
            //{
                //Debug.Write(e.Source + " " + e.InnerException);
                //MessageBox.Show(e.Message);
               // errorMessage = e.Message;
            //}
            return false;
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Encrypt(string prm_text_to_encrypt)
        {
            string _ky = Base64Encode("7E6FC60178275B1C7A0E4727F9EEC19F");
            string _iv = Base64Encode("F91CEE9F7274E0A7C1B57287106CF6E7");
            var sToEncrypt = prm_text_to_encrypt;

            var rj = new RijndaelManaged()
            {
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC,
                KeySize = 256,
                BlockSize = 256,
            };

            var key = Convert.FromBase64String(_ky);
            var IV = Convert.FromBase64String(_iv);

            var encryptor = rj.CreateEncryptor(key, IV);

            var msEncrypt = new MemoryStream();
            var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);

            var toEncrypt = Encoding.ASCII.GetBytes(sToEncrypt);

            csEncrypt.Write(toEncrypt, 0, toEncrypt.Length);
            csEncrypt.FlushFinalBlock();

            var encrypted = msEncrypt.ToArray();

            return (Convert.ToBase64String(encrypted));
        }
    }
}
