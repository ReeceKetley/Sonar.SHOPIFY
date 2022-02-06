using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Forms;
using SonarRESTOCK.Forms;
using SonarSHOPIFY.Bot_Classes;
using SonarSUPREME.General_Classes;
using SonarSUPREME.Supreme_Classes;

namespace SonarMULTI.Supreme_Classes
{
    public partial class SupremeMain : MetroForm
    {
        public List<ShopifyTask> Tasks = new List<ShopifyTask>();
        public DateTime StartTime = new DateTime();
        public bool autoStart;
        public string GlobalLog;
        public SupremeMain()
        {
            InitializeComponent();
            Win32.SetWindowTheme(olvTasks.Handle, "explorer", null);
            olvID.AspectGetter = model => ((ShopifyTask)model).ID;
            olvSite.AspectGetter = model => ((ShopifyTask) model).TaskConfig.Site.SiteName;
            olvKeyword.AspectGetter = model => ((ShopifyTask) model).TaskConfig.ProductKeyword;
            olvSize.AspectGetter = model => ((ShopifyTask)model).TaskConfig.Size;
            olvBillingProfile.AspectGetter = model => ((ShopifyTask)model).TaskConfig.BillingInfo.FullName + " " + ((ShopifyTask)model).TaskConfig.BillingInfo.cardType;
            olvProxy.AspectGetter = model => ((ShopifyTask)model).Proxy;
            olvStatus.AspectGetter = model => ((ShopifyTask)model).Status;
        }

        private void SupremeMain_Load(object sender, EventArgs e)
        {
            
            SharedData.LoadBillingInfo();
            SharedData.LoadProxies();
            SharedData.LoadCustomSites();
        }

        public void UpdateStatus(ShopifyTask task)
        {
            olvTasks.UpdateObject(task);
            GlobalLog = GlobalLog + "\r\n" + DateTime.Now.ToLongTimeString() + " - [" + task.ID + "] : " + task.Status;
            
        }



        public void AddTask(ShopifyTask task)
        {
            olvTasks.AddObject(task);
            task.frm = this;
            Tasks.Add(task);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            CreateTask c = new CreateTask(this);
            c.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (olvTasks.SelectedObjects != null && olvTasks.SelectedObjects.Count > 0)
            {
                foreach (var selectedObject in olvTasks.SelectedObjects)
                {
                    var task = (ShopifyTask) selectedObject;
                    if (!task.Running)
                    {
                        task.Start();
                        continue;
                    }
                    task.Stop();
                }
                return;
            }
            foreach (var supremeTask in Tasks)
            {
                if (supremeTask.Running)
                {
                    supremeTask.Stop();
                }
                else
                {
                    supremeTask.Start();
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var selectedObj = olvTasks.SelectedObjects;
            if (selectedObj != null)
            {
                foreach (var obj in selectedObj)
                {
                    ShopifyTask task = (ShopifyTask) obj;
                    if (task.Running)
                    {
                        task.Stop();
                        task.MainThread.Abort();
                        Tasks.Remove(task);
                        olvTasks.RemoveObject(task);
                    }
                    else
                    {
                        Tasks.Remove(task);
                        olvTasks.RemoveObject(task);
                    }
                }

            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            BillingInfoForm form = new BillingInfoForm();
            form.ShowDialog();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            ProxiesFrm frm = new ProxiesFrm();
            frm.ShowDialog();
        }

        private void metroButton3_MouseClick(object sender, MouseEventArgs e)
        {
        }

        public void StartTimer()
        {
            if (autoStart)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    metroButton3.Text = StartTime.ToShortTimeString();
                });

                Thread t = new Thread(TaskScheduler);
                t.Start();
                return;
            }
            this.Invoke((MethodInvoker)delegate
            {
                metroButton3.Text = "Start/Stop Tasks";
            });

        }

        public void TaskScheduler()
        {
            Debug.WriteLine("Task Scheduler "  + StartTime.ToShortTimeString());
            for (;;)
            {
                if (!autoStart)
                {
                    break;
                }
                if (DateTime.Now.ToShortTimeString() == StartTime.ToShortTimeString())
                {
                    Debug.WriteLine("Should start");
                    foreach (var supremeTask in Tasks)
                    {
                        if (supremeTask.Running)
                        {
                            supremeTask.Stop();
                        }
                        else
                        {
                            supremeTask.Start();
                        }
                        autoStart = false;
                        this.Invoke((MethodInvoker)delegate
                        {
                            metroButton3.Text = "Start/Stop Tasks";
                        });

                        break;
                    }
                }
                Thread.Sleep(500);
            }
        }

        private void metroButton3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SetTimeFrm frm = new SetTimeFrm(this);
                frm.ShowDialog();
            }
        }

        private void olvTasks_DoubleClick(object sender, EventArgs e)
        {
            foreach (var selectedObject in olvTasks.SelectedObjects)
            {
                ShopifyTask task = (ShopifyTask) selectedObject;
                if (task.AddedToCart && !task.TaskConfig.AutoCheckout)
                {
                    ManualCheckoutForm frm = new ManualCheckoutForm(task.TaskConfig.Site, task.supremeSession.GetCookies());

                    frm.Show();
                }
            }
        }

        private void olvTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var task = (ShopifyTask) olvTasks.SelectedObject;
                var log = "";
                foreach (string l in task.StatusLog)
                {
                    log = log + l + "\r\n";
                }
                txtLog.Text = log;
            }
            catch
            {
                
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            AutoLearn a = new AutoLearn();
            a.Show();
        }
    }
}
