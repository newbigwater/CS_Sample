using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using MPC.Views;

namespace NavigationSample
{
    public partial class Form1 : Form
    {
        private MainPage mainPage;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(SplashScree));


            lb_Clock.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            Thread.Sleep(10000);

            if (null == mainPage)
                this.mainPage = new MainPage();


            if (this.mainPage is Form)
            {
                this.mainPage.TopLevel = false;

                if (!Page.Controls.Contains(this.mainPage))
                    this.Page.Controls.Add(this.mainPage);
                this.mainPage.Dock = DockStyle.Fill;
                this.mainPage.Show();
                this.mainPage.BringToFront();
            }
            SplashScreenManager.CloseForm();
        }

        private void home_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //UserCtrlPage.Instance.Visible = false;

            Form form = this.mainPage as Form;
            SplashScreenManager.ShowForm(typeof(UserCtrl_Progress));
            {
                if (!Page.Controls.Contains(form))
                {
                    this.Page.Controls.Add(form);
                }

                Thread.Sleep(1000);
                form.Show();
            }
            SplashScreenManager.CloseForm();
            form.BringToFront();
        }

        private void history_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(NTSWaitForm));
            {
                if (!Page.Controls.Contains(UserCtrlPage.Instance))
                {
                    Page.Controls.Add(UserCtrlPage.Instance);
                    UserCtrlPage.Instance.Dock = DockStyle.Fill;
                }

                UserCtrlPage.Instance.ShowUserControl();
                Thread.Sleep(1000);
            }
            SplashScreenManager.CloseForm();

            UserCtrlPage.Instance.BringToFront();
        }

        private void tmMainTimer_Tick(object sender, EventArgs e)
        {
            lb_Clock.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
