using System.Diagnostics;
using System.Windows.Forms;
using SonarMULTI.Supreme_Classes;
using SonarRESTOCK.Forms;

namespace SonarSUPREME.General_Classes
{
    class Class1
    {
        public void open()
        {
            ApiUser user = BotConfiguration.ResponseObject.User;
            if (user == null)
            {
                BotConfiguration.max = 1000;
                SupremeMain frm = new SupremeMain();
                frm.Show();
                Debug.WriteLine("Opening");
            }
            else
            {
                Application.EnableVisualStyles();
                Application.Run(new BillingInfoForm());
            }
        }
    }
}
