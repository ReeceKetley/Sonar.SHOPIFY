using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SonarSHOPIFY.Bot_Classes
{
    public class Product
    {
        public string ProductID;
        public string ProductTitle;
        public string ProductSKU;
        public string ProductHandle;
        
        public Product(string productId, string productTitle, string productSku, string productHandle)
        {
            ProductID = productId;
            ProductTitle = productTitle;
            ProductSKU = productSku;
            ProductHandle = productHandle;
        }
    }
}
