using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SonarSHOPIFY.Bot_Classes
{
    public class ShopifySite
    {
        public string SiteName;
        public string ProductsJson;
        public string AddToCartUrl;
        public string CartUrl;

        public JObject ToJObject()
        {
            var obj = new JObject();
            obj["SiteName"] = SiteName;
            obj["ProductsJson"] = ProductsJson;
            obj["AddToCartUrl"] = AddToCartUrl;
            obj["CartUrl"] = CartUrl;
            return obj;
        }
    }
    public static class ShopifySites
    {
        public static List<ShopifySite> Sites = new List<ShopifySite>();

        static ShopifySites()
        {
            var site = new ShopifySite();
            site.SiteName = "KB24";
            site.ProductsJson = "http://store.kobebryant.com/products.json";
            site.AddToCartUrl = "http://store.kobebryant.com/cart/add.js";
            site.CartUrl = "http://store.kobebryant.com/cart";
            Sites.Add(site);
            var site1 = new ShopifySite();
            site1.SiteName = "KithNYC";
            site1.ProductsJson = "https://shop.kithnyc.com/products.json";
            site1.AddToCartUrl = "http://kithnyc.com/cart/add.js";
            site1.CartUrl = "http://kithnyc.com/cart/";
            Sites.Add(site1);
            var site2 = new ShopifySite();
            site2.SiteName = "Packer Shoes";
            site2.ProductsJson = "http://packershoes.com/products.json";
            site2.AddToCartUrl = "http://packershoes.com/cart/add.js";
            site2.CartUrl = "http://packershoes.com/cart/";
            Sites.Add(site2);
            var site3 = new ShopifySite();
            site3.SiteName = "Concepts";
            site3.ProductsJson = "http://shop.cncpts.com/products.json";
            site3.CartUrl = "http://shop.cncpts.com/cart/";
            site3.AddToCartUrl = "http://shop.cncpts.com/cart/add.js";
            Sites.Add(site3);
            var site4 = new ShopifySite();
            site4.SiteName = "Supplied";
            site4.ProductsJson = "http://get-supplied.com/products.json";
            site4.AddToCartUrl = "http://get-supplied.com/cart/add.js";
            site4.CartUrl = "http://get-supplied.com/cart";
            Sites.Add(site4);
            var site5 = new ShopifySite();
            site5.SiteName = "ShopNiceKicks";
            site5.ProductsJson = "http://shopnicekicks.com/products.json";
            site5.AddToCartUrl = "http://shopnicekicks.com/cart/add.js";
            site5.CartUrl = "http://shopnicekicks.com/cart/";
            Sites.Add(site5);
            var site6 = new ShopifySite();
            site6.SiteName = "Livestock (deadstock.ca)";
            site6.ProductsJson = "http://www.deadstock.ca/products.json";
            site6.AddToCartUrl = "http://www.deadstock.ca/cart/add.js";
            site6.CartUrl = "http://www.deadstock.ca/cart/";
            Sites.Add(site6);
            var site7 = new ShopifySite();
            site7.SiteName = "BB Branded";
            site7.ProductsJson = "http://www.bbbranded.com/products.json";
            site7.CartUrl = "http://www.bbbranded.com/cart/";
            site7.AddToCartUrl = "http://www.bbbranded.com/cart/add.js";
            Sites.Add(site7);
        }
    }
}
