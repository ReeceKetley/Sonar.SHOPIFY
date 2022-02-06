using System.Drawing;
using SonarSHOPIFY.Bot_Classes;

namespace SonarSUPREME.Supreme_Classes
{
    public class TaskConfig
    {
        public ShopifySite Site { get; private set; }
        public BillingInfo BillingInfo { get; private set; }
        public string ProductKeyword { get; set; }
        public string Size { get; private set; }
        public string Sku { get; private set; }
        public bool AutoCheckout { get; private set; }
        public bool FindBySku { get; private set; }

        public TaskConfig(string productKeyword, string size, ShopifySite site, bool findBySku = false, string sku = null, BillingInfo billingInfo = null, bool autoCheckout = false, string color = "")
        {
            BillingInfo = billingInfo;
            ProductKeyword = productKeyword;
            Size = size;
            Site = site;
            FindBySku = findBySku;
            Sku = sku;
            AutoCheckout = autoCheckout;
        }
    }
}
