﻿namespace AlarmHistory
{
    partial class MainForm
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
            DevExpress.XtraCharts.Legend legend1 = new DevExpress.XtraCharts.Legend();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
            this.alarmHistoryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.de_Start = new DevExpress.XtraEditors.DateEdit();
            this.te_End = new DevExpress.XtraEditors.TimeEdit();
            this.de_End = new DevExpress.XtraEditors.DateEdit();
            this.te_Start = new DevExpress.XtraEditors.TimeEdit();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.tp_Header = new DevExpress.Utils.Layout.TablePanel();
            this.codeFilter = new DevExpress.XtraEditors.TextEdit();
            this.eqpFilter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctcAlarmHistory = new DevExpress.XtraCharts.ChartControl();
            this.grdAlarmHistory = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceivedTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlarmCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlarmHexCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlarmTextKorean = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlarmTextChinese = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.ranAlarmHistoryGrid = new DevExpress.XtraEditors.RangeControl();
            ((System.ComponentModel.ISupportInitialize)(this.alarmHistoryTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp_Header)).BeginInit();
            this.tp_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eqpFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctcAlarmHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlarmHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ranAlarmHistoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // alarmHistoryTableBindingSource
            // 
            this.alarmHistoryTableBindingSource.DataSource = typeof(AlarmHistory.AlarmHistoryTable);
            // 
            // de_Start
            // 
            this.tp_Header.SetColumn(this.de_Start, 0);
            this.de_Start.EditValue = null;
            this.de_Start.Location = new System.Drawing.Point(3, 3);
            this.de_Start.Name = "de_Start";
            this.de_Start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Start.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tp_Header.SetRow(this.de_Start, 0);
            this.de_Start.Size = new System.Drawing.Size(124, 20);
            this.de_Start.TabIndex = 0;
            // 
            // te_End
            // 
            this.tp_Header.SetColumn(this.te_End, 4);
            this.te_End.EditValue = new System.DateTime(2020, 8, 6, 0, 0, 0, 0);
            this.te_End.Location = new System.Drawing.Point(443, 3);
            this.te_End.Name = "te_End";
            this.te_End.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.te_End.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.tp_Header.SetRow(this.te_End, 0);
            this.te_End.Size = new System.Drawing.Size(124, 20);
            this.te_End.TabIndex = 4;
            // 
            // de_End
            // 
            this.tp_Header.SetColumn(this.de_End, 3);
            this.de_End.EditValue = null;
            this.de_End.Location = new System.Drawing.Point(313, 3);
            this.de_End.Name = "de_End";
            this.de_End.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_End.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tp_Header.SetRow(this.de_End, 0);
            this.de_End.Size = new System.Drawing.Size(124, 20);
            this.de_End.TabIndex = 3;
            // 
            // te_Start
            // 
            this.tp_Header.SetColumn(this.te_Start, 1);
            this.te_Start.EditValue = new System.DateTime(2020, 8, 6, 0, 0, 0, 0);
            this.te_Start.Location = new System.Drawing.Point(133, 3);
            this.te_Start.Name = "te_Start";
            this.te_Start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.te_Start.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.tp_Header.SetRow(this.te_Start, 0);
            this.te_Start.Size = new System.Drawing.Size(124, 20);
            this.te_Start.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.tp_Header.SetColumn(this.btnSelect, 9);
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelect.Location = new System.Drawing.Point(933, 3);
            this.btnSelect.Name = "btnSelect";
            this.tp_Header.SetRow(this.btnSelect, 0);
            this.btnSelect.Size = new System.Drawing.Size(44, 21);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Search";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tp_Header
            // 
            this.tp_Header.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 130F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 130F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 130F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 130F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 130F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 130F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tp_Header.Controls.Add(this.codeFilter);
            this.tp_Header.Controls.Add(this.eqpFilter);
            this.tp_Header.Controls.Add(this.label3);
            this.tp_Header.Controls.Add(this.label2);
            this.tp_Header.Controls.Add(this.label1);
            this.tp_Header.Controls.Add(this.te_End);
            this.tp_Header.Controls.Add(this.btnSelect);
            this.tp_Header.Controls.Add(this.de_Start);
            this.tp_Header.Controls.Add(this.de_End);
            this.tp_Header.Controls.Add(this.te_Start);
            this.tp_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.tp_Header.Location = new System.Drawing.Point(0, 0);
            this.tp_Header.Name = "tp_Header";
            this.tp_Header.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F)});
            this.tp_Header.Size = new System.Drawing.Size(1350, 27);
            this.tp_Header.TabIndex = 2;
            // 
            // codeFilter
            // 
            this.tp_Header.SetColumn(this.codeFilter, 8);
            this.codeFilter.Location = new System.Drawing.Point(803, 3);
            this.codeFilter.Name = "codeFilter";
            this.tp_Header.SetRow(this.codeFilter, 0);
            this.codeFilter.Size = new System.Drawing.Size(124, 20);
            this.codeFilter.TabIndex = 10;
            // 
            // eqpFilter
            // 
            this.tp_Header.SetColumn(this.eqpFilter, 6);
            this.eqpFilter.Location = new System.Drawing.Point(623, 3);
            this.eqpFilter.Name = "eqpFilter";
            this.eqpFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tp_Header.SetRow(this.eqpFilter, 0);
            this.eqpFilter.Size = new System.Drawing.Size(124, 20);
            this.eqpFilter.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tp_Header.SetColumn(this.label3, 7);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(753, 0);
            this.label3.Name = "label3";
            this.tp_Header.SetRow(this.label3, 0);
            this.label3.Size = new System.Drawing.Size(44, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tp_Header.SetColumn(this.label2, 5);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(573, 0);
            this.label2.Name = "label2";
            this.tp_Header.SetRow(this.label2, 0);
            this.label2.Size = new System.Drawing.Size(44, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "EQP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tp_Header.SetColumn(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(263, 0);
            this.label1.Name = "label1";
            this.tp_Header.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(44, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctcAlarmHistory
            // 
            this.tablePanel1.SetColumn(this.ctcAlarmHistory, 0);
            this.ctcAlarmHistory.DataSource = this.alarmHistoryTableBindingSource;
            this.ctcAlarmHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctcAlarmHistory.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.LeftOutside;
            this.ctcAlarmHistory.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center;
            this.ctcAlarmHistory.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            this.ctcAlarmHistory.Legend.Name = "Default Legend";
            this.ctcAlarmHistory.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            legend1.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            legend1.Name = "Legend1";
            legend1.Tag = "";
            legend1.Title.Text = "Alarm History";
            legend1.Title.Visible = true;
            this.ctcAlarmHistory.Legends.AddRange(new DevExpress.XtraCharts.Legend[] {
            legend1});
            this.ctcAlarmHistory.Location = new System.Drawing.Point(3, 3);
            this.ctcAlarmHistory.Name = "ctcAlarmHistory";
            this.tablePanel1.SetRow(this.ctcAlarmHistory, 0);
            this.ctcAlarmHistory.SeriesDataMember = "Unit";
            this.ctcAlarmHistory.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.ctcAlarmHistory.SeriesTemplate.ArgumentDataMember = "AlarmHexCode";
            pieSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            pieSeriesLabel1.TextAlignment = System.Drawing.StringAlignment.Near;
            pieSeriesLabel1.TextPattern = "{A}:{V}";
            this.ctcAlarmHistory.SeriesTemplate.Label = pieSeriesLabel1;
            this.ctcAlarmHistory.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.ctcAlarmHistory.SeriesTemplate.LegendName = "Default Legend";
            this.ctcAlarmHistory.SeriesTemplate.SeriesColorizer = null;
            this.ctcAlarmHistory.SeriesTemplate.SeriesDataMember = "Unit";
            this.ctcAlarmHistory.SeriesTemplate.ValueDataMembersSerializable = "Count";
            pieSeriesView1.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
            pieSeriesView1.TotalLabel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctcAlarmHistory.SeriesTemplate.View = pieSeriesView1;
            this.ctcAlarmHistory.Size = new System.Drawing.Size(617, 593);
            this.ctcAlarmHistory.TabIndex = 1;
            // 
            // grdAlarmHistory
            // 
            this.tablePanel2.SetColumn(this.grdAlarmHistory, 0);
            this.grdAlarmHistory.DataSource = this.alarmHistoryTableBindingSource;
            this.grdAlarmHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAlarmHistory.Location = new System.Drawing.Point(3, 3);
            this.grdAlarmHistory.MainView = this.gridView1;
            this.grdAlarmHistory.Name = "grdAlarmHistory";
            this.tablePanel2.SetRow(this.grdAlarmHistory, 0);
            this.grdAlarmHistory.Size = new System.Drawing.Size(718, 685);
            this.grdAlarmHistory.TabIndex = 2;
            this.grdAlarmHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUnit,
            this.colCategory,
            this.colReceivedTime,
            this.colAlarmCode,
            this.colAlarmHexCode,
            this.colAlarmTextKorean,
            this.colAlarmTextChinese,
            this.colCount});
            this.gridView1.GridControl = this.grdAlarmHistory;
            this.gridView1.Name = "gridView1";
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 0;
            this.colUnit.Width = 53;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 1;
            this.colCategory.Width = 62;
            // 
            // colReceivedTime
            // 
            this.colReceivedTime.FieldName = "ReceivedTime";
            this.colReceivedTime.Name = "colReceivedTime";
            this.colReceivedTime.Visible = true;
            this.colReceivedTime.VisibleIndex = 2;
            this.colReceivedTime.Width = 143;
            // 
            // colAlarmCode
            // 
            this.colAlarmCode.FieldName = "AlarmCode";
            this.colAlarmCode.Name = "colAlarmCode";
            this.colAlarmCode.Visible = true;
            this.colAlarmCode.VisibleIndex = 3;
            this.colAlarmCode.Width = 102;
            // 
            // colAlarmHexCode
            // 
            this.colAlarmHexCode.FieldName = "AlarmHexCode";
            this.colAlarmHexCode.Name = "colAlarmHexCode";
            this.colAlarmHexCode.Visible = true;
            this.colAlarmHexCode.VisibleIndex = 4;
            this.colAlarmHexCode.Width = 102;
            // 
            // colAlarmTextKorean
            // 
            this.colAlarmTextKorean.FieldName = "AlarmTextKorean";
            this.colAlarmTextKorean.Name = "colAlarmTextKorean";
            this.colAlarmTextKorean.Visible = true;
            this.colAlarmTextKorean.VisibleIndex = 5;
            this.colAlarmTextKorean.Width = 102;
            // 
            // colAlarmTextChinese
            // 
            this.colAlarmTextChinese.FieldName = "AlarmTextChinese";
            this.colAlarmTextChinese.Name = "colAlarmTextChinese";
            this.colAlarmTextChinese.Visible = true;
            this.colAlarmTextChinese.VisibleIndex = 6;
            this.colAlarmTextChinese.Width = 102;
            // 
            // colCount
            // 
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 7;
            this.colCount.Width = 110;
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30.04F)});
            this.tablePanel2.Controls.Add(this.grdAlarmHistory);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablePanel2.Location = new System.Drawing.Point(0, 27);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 599F)});
            this.tablePanel2.Size = new System.Drawing.Size(724, 691);
            this.tablePanel2.TabIndex = 3;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.ranAlarmHistoryGrid);
            this.tablePanel1.Controls.Add(this.ctcAlarmHistory);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tablePanel1.Location = new System.Drawing.Point(727, 27);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 599F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(623, 691);
            this.tablePanel1.TabIndex = 4;
            // 
            // ranAlarmHistoryGrid
            // 
            this.ranAlarmHistoryGrid.Client = this.ctcAlarmHistory;
            this.tablePanel1.SetColumn(this.ranAlarmHistoryGrid, 0);
            this.ranAlarmHistoryGrid.Location = new System.Drawing.Point(3, 602);
            this.ranAlarmHistoryGrid.Name = "ranAlarmHistoryGrid";
            this.tablePanel1.SetRow(this.ranAlarmHistoryGrid, 1);
            this.ranAlarmHistoryGrid.Size = new System.Drawing.Size(617, 86);
            this.ranAlarmHistoryGrid.TabIndex = 3;
            this.ranAlarmHistoryGrid.Text = "rangeControl1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 718);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.tablePanel2);
            this.Controls.Add(this.tp_Header);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alarmHistoryTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp_Header)).EndInit();
            this.tp_Header.ResumeLayout(false);
            this.tp_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eqpFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctcAlarmHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlarmHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ranAlarmHistoryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DateEdit de_Start;
        private DevExpress.XtraEditors.TimeEdit te_Start;
        private DevExpress.XtraEditors.DateEdit de_End;
        private DevExpress.XtraEditors.TimeEdit te_End;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private System.Windows.Forms.BindingSource alarmHistoryTableBindingSource;
        private DevExpress.Utils.Layout.TablePanel tp_Header;
        private DevExpress.XtraEditors.TextEdit codeFilter;
        private DevExpress.XtraEditors.ComboBoxEdit eqpFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraCharts.ChartControl ctcAlarmHistory;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraGrid.GridControl grdAlarmHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colReceivedTime;
        private DevExpress.XtraGrid.Columns.GridColumn colAlarmCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAlarmHexCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAlarmTextKorean;
        private DevExpress.XtraGrid.Columns.GridColumn colAlarmTextChinese;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.RangeControl ranAlarmHistoryGrid;
    }
}