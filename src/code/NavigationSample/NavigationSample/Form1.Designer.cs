using System.Windows.Forms;

namespace NavigationSample
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            this.navBarCtrl = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.home = new DevExpress.XtraNavBar.NavBarItem();
            this.history = new DevExpress.XtraNavBar.NavBarItem();
            this.RealTimeCharts = new DevExpress.XtraNavBar.NavBarItem();
            this.exit = new DevExpress.XtraNavBar.NavBarItem();
            this.TopBar = new System.Windows.Forms.Panel();
            this.ClockPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_Clock = new System.Windows.Forms.Label();
            this.Page = new System.Windows.Forms.Panel();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::MPC.Views.NTSWaitForm), true, true);
            this.tmMainTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navBarCtrl)).BeginInit();
            this.TopBar.SuspendLayout();
            this.ClockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBarCtrl
            // 
            this.navBarCtrl.ActiveGroup = this.navBarGroup1;
            this.navBarCtrl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarCtrl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarCtrl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.home,
            this.history,
            this.RealTimeCharts,
            this.exit});
            this.navBarCtrl.Location = new System.Drawing.Point(0, 0);
            this.navBarCtrl.Name = "navBarCtrl";
            this.navBarCtrl.OptionsNavPane.ExpandedWidth = 140;
            this.navBarCtrl.Size = new System.Drawing.Size(140, 661);
            this.navBarCtrl.TabIndex = 1;
            this.navBarCtrl.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Menu";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ImageOptions.SmallImage = global::NavigationSample.Properties.Resources.logo;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.home),
            new DevExpress.XtraNavBar.NavBarItemLink(this.history),
            new DevExpress.XtraNavBar.NavBarItemLink(this.RealTimeCharts),
            new DevExpress.XtraNavBar.NavBarItemLink(this.exit)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // home
            // 
            this.home.Caption = "HOME";
            this.home.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("home.ImageOptions.LargeImage")));
            this.home.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("home.ImageOptions.SmallImage")));
            this.home.Name = "home";
            this.home.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.home_LinkClicked);
            // 
            // history
            // 
            this.history.Caption = "HISTORY";
            this.history.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("history.ImageOptions.LargeImage")));
            this.history.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("history.ImageOptions.SmallImage")));
            this.history.Name = "history";
            this.history.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.history_LinkClicked);
            // 
            // RealTimeCharts
            // 
            this.RealTimeCharts.Caption = "Real-Time Charts";
            this.RealTimeCharts.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RealTimeCharts.ImageOptions.LargeImage")));
            this.RealTimeCharts.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("RealTimeCharts.ImageOptions.SmallImage")));
            this.RealTimeCharts.Name = "RealTimeCharts";
            // 
            // exit
            // 
            this.exit.Caption = "EXIT";
            this.exit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("exit.ImageOptions.LargeImage")));
            this.exit.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("exit.ImageOptions.SmallImage")));
            this.exit.Name = "exit";
            toolTipTitleItem1.Text = "exit";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Exit the application.";
            toolTipTitleItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem2.LeftIndent = 6;
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            superToolTip1.Items.Add(toolTipTitleItem2);
            this.exit.SuperTip = superToolTip1;
            // 
            // TopBar
            // 
            this.TopBar.Controls.Add(this.ClockPanel);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(140, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1282, 39);
            this.TopBar.TabIndex = 2;
            // 
            // ClockPanel
            // 
            this.ClockPanel.Controls.Add(this.lb_Clock);
            this.ClockPanel.Location = new System.Drawing.Point(1015, 0);
            this.ClockPanel.Name = "ClockPanel";
            this.ClockPanel.Size = new System.Drawing.Size(267, 39);
            this.ClockPanel.TabIndex = 0;
            // 
            // lb_Clock
            // 
            this.lb_Clock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Clock.BackColor = System.Drawing.Color.White;
            this.lb_Clock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_Clock.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Clock.Image = global::NavigationSample.Properties.Resources.txtClock_Image;
            this.lb_Clock.Location = new System.Drawing.Point(3, 0);
            this.lb_Clock.Name = "lb_Clock";
            this.lb_Clock.Size = new System.Drawing.Size(261, 39);
            this.lb_Clock.TabIndex = 0;
            this.lb_Clock.Text = "Clock";
            this.lb_Clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Page
            // 
            this.Page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Page.Location = new System.Drawing.Point(140, 39);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(1282, 622);
            this.Page.TabIndex = 3;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // tmMainTimer
            // 
            this.tmMainTimer.Enabled = true;
            this.tmMainTimer.Tick += new System.EventHandler(this.tmMainTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 661);
            this.Controls.Add(this.Page);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.navBarCtrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarCtrl)).EndInit();
            this.TopBar.ResumeLayout(false);
            this.ClockPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarControl navBarCtrl;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem home;
        private DevExpress.XtraNavBar.NavBarItem history;
        private DevExpress.XtraNavBar.NavBarItem RealTimeCharts;
        private DevExpress.XtraNavBar.NavBarItem exit;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Panel Page;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private FlowLayoutPanel ClockPanel;
        private Label lb_Clock;
        private Timer tmMainTimer;

        /*        public UserCtrlPage mainPage { get; set; }*/
    }
}

