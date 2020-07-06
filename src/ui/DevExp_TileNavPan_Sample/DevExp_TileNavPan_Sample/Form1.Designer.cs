namespace DevExp_TileNavPan_Sample
{
    partial class MainForm
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
            DevExpress.XtraSplashScreen.SplashScreenManager mainSplashScreenMgr = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.topPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuBar = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.btnMenu = new DevExpress.XtraBars.Navigation.NavButton();
            this.menu_home = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.menu_history = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.menu_histor_alarm = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.menu_history_sensor = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.menu_exit = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplashScreenMgr
            // 
            mainSplashScreenMgr.ClosingDelay = 500;
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.topPanel, 0, 0);
            this.mainPanel.Controls.Add(this.menuBar, 0, 1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 3;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 679F));
            this.mainPanel.Size = new System.Drawing.Size(1404, 800);
            this.mainPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.ColumnCount = 5;
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.773585F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.86792F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.86793F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.62264F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.86793F));
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.RowCount = 1;
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.topPanel.Size = new System.Drawing.Size(1398, 44);
            this.topPanel.TabIndex = 0;
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(208)))));
            this.menuBar.Buttons.Add(this.btnMenu);
            this.menuBar.Categories.AddRange(new DevExpress.XtraBars.Navigation.TileNavCategory[] {
            this.menu_home,
            this.menu_history,
            this.menu_exit});
            // 
            // menuBar_menu
            // 
            this.menuBar.DefaultCategory.Name = "menuBar_menu";
            // 
            // 
            // 
            this.menuBar.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.menuBar.DefaultCategory.Tile.Elements.Add(tileItemElement6);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuBar.Location = new System.Drawing.Point(3, 53);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1398, 44);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuBar";
            this.menuBar.SelectedElementChanged += new DevExpress.XtraBars.Navigation.TileNavPaneElementEventHandler(this.menuBar_SelectedElementChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.Caption = "Menu";
            this.btnMenu.IsMain = true;
            this.btnMenu.Name = "btnMenu";
            // 
            // menu_home
            // 
            this.menu_home.Caption = "Home";
            this.menu_home.Name = "menu_home";
            // 
            // 
            // 
            this.menu_home.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menu_home.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.menu_home.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menu_home.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.menu_home.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement1.Text = "Home";
            this.menu_home.Tile.Elements.Add(tileItemElement1);
            this.menu_home.Tile.Name = "tileBarItem2";
            // 
            // menu_history
            // 
            this.menu_history.Caption = "History";
            this.menu_history.Items.AddRange(new DevExpress.XtraBars.Navigation.TileNavItem[] {
            this.menu_histor_alarm,
            this.menu_history_sensor});
            this.menu_history.Name = "menu_history";
            // 
            // 
            // 
            this.menu_history.Tile.AppearanceItem.Normal.BackColor = System.Drawing.SystemColors.Highlight;
            this.menu_history.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.menu_history.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menu_history.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.menu_history.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            tileItemElement4.Text = "History";
            this.menu_history.Tile.Elements.Add(tileItemElement4);
            this.menu_history.Tile.Name = "tileBarItem3";
            // 
            // menu_histor_alarm
            // 
            this.menu_histor_alarm.Caption = "Alarm History";
            this.menu_histor_alarm.Name = "menu_histor_alarm";
            // 
            // 
            // 
            this.menu_histor_alarm.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menu_histor_alarm.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.menu_histor_alarm.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menu_histor_alarm.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.menu_histor_alarm.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement2.Text = "Alarm History";
            this.menu_histor_alarm.Tile.Elements.Add(tileItemElement2);
            this.menu_histor_alarm.Tile.Name = "tileBarItem1";
            // 
            // menu_history_sensor
            // 
            this.menu_history_sensor.Caption = "Sensor History";
            this.menu_history_sensor.Name = "menu_history_sensor";
            // 
            // 
            // 
            this.menu_history_sensor.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menu_history_sensor.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.menu_history_sensor.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menu_history_sensor.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.menu_history_sensor.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement3.Text = "Sensor History";
            this.menu_history_sensor.Tile.Elements.Add(tileItemElement3);
            this.menu_history_sensor.Tile.Name = "tileBarItem4";
            // 
            // menu_exit
            // 
            this.menu_exit.Caption = "Exit";
            this.menu_exit.Name = "menu_exit";
            // 
            // 
            // 
            this.menu_exit.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menu_exit.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.menu_exit.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menu_exit.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.menu_exit.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            tileItemElement5.Text = "Exit";
            this.menu_exit.Tile.Elements.Add(tileItemElement5);
            this.menu_exit.Tile.Name = "tileBarItem6";
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 800);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.TableLayoutPanel topPanel;
        private DevExpress.XtraBars.Navigation.TileNavPane menuBar;
        private DevExpress.XtraBars.Navigation.NavButton btnMenu;
        private DevExpress.XtraBars.Navigation.TileNavCategory menu_home;
        private DevExpress.XtraBars.Navigation.TileNavCategory menu_history;
        private DevExpress.XtraBars.Navigation.TileNavItem menu_histor_alarm;
        private DevExpress.XtraBars.Navigation.TileNavItem menu_history_sensor;
        private DevExpress.XtraBars.Navigation.TileNavCategory menu_exit;
        private System.Windows.Forms.Timer mainTimer;
    }
}

