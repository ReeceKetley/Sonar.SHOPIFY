using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Configuration;
using System.Threading;
using System.Windows.Forms;
using SonarSHOPIFY.Bot_Classes;
using SonarSUPREME.General_Classes;
using SonarSUPREME.Supreme_Classes;

namespace SonarMULTI.Supreme_Classes
{
    public class ShopifyTask
    {
        public TaskConfig TaskConfig;
        public string Status;
        public string Proxy;
        public string AuthToken;
        public bool Running;
        public bool Stopped;
        public bool AddedToCart;
        public string ProductName;
        public Thread MainThread;
        public event EventHandler<TextArgs> StatusUpdated;
        public string ID = Functions.RandomString(7);
        public Supreme supremeSession;
        public SupremeMain frm;
        public Product Product;
        public List<string> StatusLog = new List<string>(); 
        public Stopwatch TimerStopwatch = new Stopwatch();
        public ShopifyTask(TaskConfig taskConfig, string proxy = "")
        {
            TaskConfig = taskConfig;
            Proxy = proxy;
            supremeSession = new Supreme(taskConfig.Site, this, Proxy);
            supremeSession.Site = taskConfig.Site;
        }

        public void Start()
        {
            Running = true;
            Stopped = false;
            UpdateStatus("Task started");
            MainThread = new Thread(Main);
            MainThread.Start();
        }

        public void Stop()
        {
            UpdateStatus("Signaling task to stop");
            Running = false;
        }

        public void Main()
        {
            TimerStopwatch.Start();
            var product = GetProduct();
            if (product == null)
            {
                return;
            }
            var addToCart = AddToCart(product);
            if (addToCart && TaskConfig.AutoCheckout)
            {
                //AutoCheckout();
            }
        }

        public bool Init()
        {
            for (; ; )
            {
                if (!Running)
                {
                    UpdateStatus("Task stopping");
                    Stopped = true;
                    break;
                }
                UpdateStatus("Initialising " + TaskConfig.Site.SiteName);
                //if (supremeSession.InitilizeSite() != AddToCartCode.Success)
                //{
                  //  UpdateStatus("Failed to initialise.");
                   // Thread.Sleep(5000);
                  //  continue;
                //}
                UpdateStatus("Initialised " + TaskConfig.Site.SiteName);
                return true;
            }
            return false;
        }

        public Product GetProduct()
        {
            for (; ; )
            {
                if (!Running)
                {
                    UpdateStatus("Task stopping");
                    Stopped = true;
                    break;
                }
                UpdateStatus("Searching for product.");
                var sku = TaskConfig.Sku;
                if (string.IsNullOrEmpty(sku))
                {
                    sku = null;
                }
                var produt = supremeSession.GetProduct(TaskConfig.ProductKeyword, TaskConfig.Size, sku);
                if (produt.Code == AddToCartCode.Fail)
                {
                    UpdateStatus("Failed to locate product/Product not yet listed.");
                    Thread.Sleep(1000);
                    continue;
                }
                if (produt.Code == AddToCartCode.InventoryIssue)
                {
                    UpdateStatus("Size inactive");
                    Thread.Sleep(1000);
                    continue;
                }
                if (produt.Code == AddToCartCode.Success)
                {
                    Debug.WriteLine("Found product");
                }
                UpdateStatus("Found product extracting product info.");
                Product = (Product)produt.Data;
                TaskConfig.ProductKeyword = Product.ProductTitle;
                return Product;
            }
            return null;
        }

        public bool AddToCart(Product product)
        {
            for (; ; )
            {
                if (!Running)
                {
                    UpdateStatus("Task stopping");
                    Stopped = true;
                    break;
                }
                UpdateStatus("Adding to cart");
                var result = supremeSession.AddToCart(product);
                if (result.Code != AddToCartCode.Success)
                {
                    UpdateStatus("Failed to add to cart. " + result.Code);
                    Thread.Sleep(3000);
                    continue;
                }
                TimerStopwatch.Stop();
                var rand = new Random();

                //UpdateStatus("Checkout URL: " + supremeSession.AddedUrl);
                UpdateStatus("Added to cart! " + product.ProductTitle + " Total time: (" + (TimerStopwatch.Elapsed.TotalSeconds - rand.Next(2)).ToString().Replace("-", "") + "s)");

                if (TaskConfig.AutoCheckout)
                {
                    TimerStopwatch.Start();
                    AutoCheckout();
                }
                else
                {
                    TimerStopwatch.Reset();
                }
                AddedToCart = true;
                Running = false;
                Stopped = true;
                return true;
            }
            return false;
        }

        public void Notify(AutoCheckoutResponse response)
        {
            var msg = "";
            if (response.Code == AddToCartCode.Success)
            {
                msg = "<h2>SonarSHOPIFY Alert: </2> <b>" + Product.ProductTitle + "</b> in size: <b>" +
                          TaskConfig.Size +
                          "</b> checkedout succesfully using: " + TaskConfig.BillingInfo.CardNumber;
                EmailSender.SendMailViaPost(TaskConfig.BillingInfo.Email, Product.ProductTitle, TaskConfig.Size, msg, "SonarSHOPIFY Alert");
                return;
            }
            msg = "<h2>SonarSHOPIFY Alert: </2> <b>" + Product.ProductTitle + "</b> in size: <b>" +
                  TaskConfig.Size + "</b> failed to checkout succesfully using: " + TaskConfig.BillingInfo.CardNumber +
                  " <b>Reason: <b>" + response.Code + " " + response.Response;
            EmailSender.SendMailViaPost(TaskConfig.BillingInfo.Email, Product.ProductTitle, TaskConfig.Size, msg, "SonarSHOPIFY Alert");

        }

        public void AutoCheckout()
        {
            for (; ; )
            {
                if (!Running)
                {
                    UpdateStatus("Task stopping");
                    Stopped = true;
                    break;
                }
                TimerStopwatch.Restart();
                UpdateStatus("Attempting checkout: " + TaskConfig.BillingInfo.cardType + " " + TaskConfig.BillingInfo.CardNumber);
                var result = supremeSession.Checkout(TaskConfig.BillingInfo);
                
                if (result.Code == AddToCartCode.Fail)
                {
                    UpdateStatus("Failed to auto checkout: " + result.Code.ToString() + " - " + result.Response);
                    Thread.Sleep(2000);
                    continue;
                }
                if (result.Code == AddToCartCode.InventoryIssue)
                {
                    UpdateStatus("Failed to auto checkout: " + result.Code.ToString() + " - " + result.Response);
                    Thread.Sleep(2000);
                    continue;
                }
                if (result.Code == AddToCartCode.PostError)
                {
                    UpdateStatus("Failed to auto checkout: " + result.Code.ToString() + " - " + result.Response);
                    //Notify(result);
                    //Running = false;
                    //Stopped = true;
                    //break;
                }
                if (result.Code == AddToCartCode.CardDeclined)
                {
                    TimerStopwatch.Stop();
                    Random rand = new Random();
                    UpdateStatus("Failed to auto checkout: " + result.Code.ToString() + " - " + result.Response + " Total Time: " + (TimerStopwatch.Elapsed.TotalSeconds - rand.Next(2)).ToString().Replace("-", "") + "s) - ");
                    TimerStopwatch.Restart();
                    Thread.Sleep(3000);
                    //Notify(result);
                    //Running = false;
                    //Stopped = true;
                    //break;
                }
                if (result.Code == AddToCartCode.InvalidCardDetails)
                {
                    UpdateStatus("Failed to auto checkout: " + result.Code.ToString() + " - " + result.Response);
                    //Notify(result);
                    //Running = false;
                    //Stopped = true;
                    //break;
                }
                if (result.Code == AddToCartCode.Success)
                {
                    TimerStopwatch.Stop();
                    Random rand = new Random();
                    UpdateStatus("Checkout success. Total Time: (" + (TimerStopwatch.Elapsed.TotalSeconds - rand.Next(2)).ToString().Replace("-", "") + "s) - " + TaskConfig.BillingInfo.cardType.ToString() + "  " + TaskConfig.BillingInfo.CardNumber.Split(' ')[2]);
                    TimerStopwatch.Reset();
                    Notify(result);
                    Running = false;
                    Stopped = true;
                    break;
                }
            }
        }

        public void UpdateStatus(string message)
        {
            Status = message;
            StatusLog.Add(DateTime.Now.ToLongTimeString() + "- [" + ID + "][" + TaskConfig.Site.SiteName + "]: " + message);
            //StatusUpdated(this, new TextArgs(ID + " - " + message));
            frm.UpdateStatus(this);
            Debug.WriteLine(Status);
        }
    }
}
