namespace DevExpress
{
    partial class XtraForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.OldTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sampleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MarriedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForOld = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMarried = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tM1_BUFFERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colReceivedTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colO2PPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colO2Percent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colH2PPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPressure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OldTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarriedCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMarried)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tM1_BUFFERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(37, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(155, 47);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.OldTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MarriedCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhoneTextEdit);
            this.dataLayoutControl1.DataSource = this.sampleBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(5, 25);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(459, 166);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // OldTextEdit
            // 
            this.OldTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sampleBindingSource, "Old", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OldTextEdit.Location = new System.Drawing.Point(62, 43);
            this.OldTextEdit.Name = "OldTextEdit";
            this.OldTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.OldTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.OldTextEdit.Properties.Mask.EditMask = "N0";
            this.OldTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.OldTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.OldTextEdit.Size = new System.Drawing.Size(373, 20);
            this.OldTextEdit.StyleController = this.dataLayoutControl1;
            this.OldTextEdit.TabIndex = 4;
            // 
            // sampleBindingSource
            // 
            this.sampleBindingSource.DataSource = typeof(DevExpress.Sample);
            // 
            // MarriedCheckEdit
            // 
            this.MarriedCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sampleBindingSource, "Married", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MarriedCheckEdit.Location = new System.Drawing.Point(24, 67);
            this.MarriedCheckEdit.Name = "MarriedCheckEdit";
            this.MarriedCheckEdit.Properties.Caption = "Married";
            this.MarriedCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.MarriedCheckEdit.Size = new System.Drawing.Size(411, 19);
            this.MarriedCheckEdit.StyleController = this.dataLayoutControl1;
            this.MarriedCheckEdit.TabIndex = 5;
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sampleBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NameTextEdit.Location = new System.Drawing.Point(62, 90);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(373, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 6;
            // 
            // PhoneTextEdit
            // 
            this.PhoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sampleBindingSource, "Phone", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PhoneTextEdit.Location = new System.Drawing.Point(62, 114);
            this.PhoneTextEdit.Name = "PhoneTextEdit";
            this.PhoneTextEdit.Size = new System.Drawing.Size(373, 20);
            this.PhoneTextEdit.StyleController = this.dataLayoutControl1;
            this.PhoneTextEdit.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(459, 166);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(439, 146);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForOld,
            this.ItemForMarried,
            this.ItemForName,
            this.ItemForPhone});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(439, 146);
            // 
            // ItemForOld
            // 
            this.ItemForOld.Control = this.OldTextEdit;
            this.ItemForOld.Location = new System.Drawing.Point(0, 0);
            this.ItemForOld.Name = "ItemForOld";
            this.ItemForOld.Size = new System.Drawing.Size(415, 24);
            this.ItemForOld.Text = "Old";
            this.ItemForOld.TextSize = new System.Drawing.Size(35, 14);
            // 
            // ItemForMarried
            // 
            this.ItemForMarried.Control = this.MarriedCheckEdit;
            this.ItemForMarried.Location = new System.Drawing.Point(0, 24);
            this.ItemForMarried.Name = "ItemForMarried";
            this.ItemForMarried.Size = new System.Drawing.Size(415, 23);
            this.ItemForMarried.Text = "Married";
            this.ItemForMarried.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForMarried.TextVisible = false;
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 47);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(415, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(35, 14);
            // 
            // ItemForPhone
            // 
            this.ItemForPhone.Control = this.PhoneTextEdit;
            this.ItemForPhone.Location = new System.Drawing.Point(0, 71);
            this.ItemForPhone.Name = "ItemForPhone";
            this.ItemForPhone.Size = new System.Drawing.Size(415, 32);
            this.ItemForPhone.Text = "Phone";
            this.ItemForPhone.TextSize = new System.Drawing.Size(35, 14);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(439, 421);
            this.layoutControlGroup2.Text = "sample";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tM1_BUFFERBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(37, 353);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(509, 296);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tM1_BUFFERBindingSource
            // 
            this.tM1_BUFFERBindingSource.DataSource = typeof(DevExpress.TM1_BUFFER);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colReceivedTime,
            this.colO2PPM,
            this.colO2Percent,
            this.colH2PPM,
            this.colPressure});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colReceivedTime
            // 
            this.colReceivedTime.FieldName = "ReceivedTime";
            this.colReceivedTime.Name = "colReceivedTime";
            this.colReceivedTime.Visible = true;
            this.colReceivedTime.VisibleIndex = 0;
            // 
            // colO2PPM
            // 
            this.colO2PPM.FieldName = "O2PPM";
            this.colO2PPM.Name = "colO2PPM";
            this.colO2PPM.Visible = true;
            this.colO2PPM.VisibleIndex = 1;
            // 
            // colO2Percent
            // 
            this.colO2Percent.FieldName = "O2Percent";
            this.colO2Percent.Name = "colO2Percent";
            this.colO2Percent.Visible = true;
            this.colO2Percent.VisibleIndex = 2;
            // 
            // colH2PPM
            // 
            this.colH2PPM.FieldName = "H2PPM";
            this.colH2PPM.Name = "colH2PPM";
            this.colH2PPM.Visible = true;
            this.colH2PPM.VisibleIndex = 3;
            // 
            // colPressure
            // 
            this.colPressure.FieldName = "Pressure";
            this.colPressure.Name = "colPressure";
            this.colPressure.Visible = true;
            this.colPressure.VisibleIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dataLayoutControl1);
            this.panelControl1.Location = new System.Drawing.Point(37, 107);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(479, 212);
            this.panelControl1.TabIndex = 3;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.panelControl2);
            this.tablePanel1.Location = new System.Drawing.Point(666, 87);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(562, 480);
            this.tablePanel1.TabIndex = 4;
            // 
            // panelControl2
            // 
            this.tablePanel1.SetColumn(this.panelControl2, 1);
            this.panelControl2.Location = new System.Drawing.Point(9, 29);
            this.panelControl2.Name = "panelControl2";
            this.tablePanel1.SetRow(this.panelControl2, 1);
            this.panelControl2.Size = new System.Drawing.Size(55, 20);
            this.panelControl2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OldTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarriedCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMarried)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tM1_BUFFERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.SimpleButton simpleButton1;
        private XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource sampleBindingSource;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraEditors.TextEdit OldTextEdit;
        private XtraEditors.CheckEdit MarriedCheckEdit;
        private XtraEditors.TextEdit NameTextEdit;
        private XtraEditors.TextEdit PhoneTextEdit;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlItem ItemForOld;
        private XtraLayout.LayoutControlItem ItemForMarried;
        private XtraLayout.LayoutControlItem ItemForName;
        private XtraLayout.LayoutControlItem ItemForPhone;
        private XtraGrid.GridControl gridControl1;
        private XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tM1_BUFFERBindingSource;
        private XtraGrid.Columns.GridColumn colReceivedTime;
        private XtraGrid.Columns.GridColumn colO2PPM;
        private XtraGrid.Columns.GridColumn colO2Percent;
        private XtraGrid.Columns.GridColumn colH2PPM;
        private XtraGrid.Columns.GridColumn colPressure;
        private XtraEditors.PanelControl panelControl1;
        private Utils.Layout.TablePanel tablePanel1;
        private XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button button1;
    }
}