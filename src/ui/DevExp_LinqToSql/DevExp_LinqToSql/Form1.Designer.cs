namespace DevExp_LinqToSql
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.nTSDataSet = new DevExp_LinqToSql.NTSDataSet();
            this.nTSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alarmTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colReceivedTime = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAlarmCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAlarmHexCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAlarmHappen = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCategory = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colUnit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAlarmTextKorean = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAlarmTextChinese = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colReceivedTime,
            this.colAlarmCode,
            this.colAlarmHexCode,
            this.colAlarmHappen,
            this.colCategory,
            this.colUnit,
            this.colAlarmTextKorean,
            this.colAlarmTextChinese});
            this.treeList1.DataSource = this.alarmTableBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(868, 524);
            this.treeList1.TabIndex = 0;
            // 
            // nTSDataSet
            // 
            this.nTSDataSet.DataSetName = "NTSDataSet";
            this.nTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nTSDataSetBindingSource
            // 
            this.nTSDataSetBindingSource.DataSource = this.nTSDataSet;
            this.nTSDataSetBindingSource.Position = 0;
            // 
            // alarmTableBindingSource
            // 
            this.alarmTableBindingSource.DataSource = typeof(DevExp_LinqToSql.AlarmTable);
            // 
            // colReceivedTime
            // 
            this.colReceivedTime.FieldName = "ReceivedTime";
            this.colReceivedTime.Name = "colReceivedTime";
            this.colReceivedTime.Visible = true;
            this.colReceivedTime.VisibleIndex = 0;
            // 
            // colAlarmCode
            // 
            this.colAlarmCode.FieldName = "AlarmCode";
            this.colAlarmCode.Name = "colAlarmCode";
            this.colAlarmCode.Visible = true;
            this.colAlarmCode.VisibleIndex = 1;
            // 
            // colAlarmHexCode
            // 
            this.colAlarmHexCode.FieldName = "AlarmHexCode";
            this.colAlarmHexCode.Name = "colAlarmHexCode";
            this.colAlarmHexCode.Visible = true;
            this.colAlarmHexCode.VisibleIndex = 2;
            // 
            // colAlarmHappen
            // 
            this.colAlarmHappen.FieldName = "AlarmHappen";
            this.colAlarmHappen.Name = "colAlarmHappen";
            this.colAlarmHappen.Visible = true;
            this.colAlarmHappen.VisibleIndex = 3;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 4;
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 5;
            // 
            // colAlarmTextKorean
            // 
            this.colAlarmTextKorean.FieldName = "AlarmTextKorean";
            this.colAlarmTextKorean.Name = "colAlarmTextKorean";
            this.colAlarmTextKorean.Visible = true;
            this.colAlarmTextKorean.VisibleIndex = 6;
            // 
            // colAlarmTextChinese
            // 
            this.colAlarmTextChinese.FieldName = "AlarmTextChinese";
            this.colAlarmTextChinese.Name = "colAlarmTextChinese";
            this.colAlarmTextChinese.Visible = true;
            this.colAlarmTextChinese.VisibleIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 524);
            this.Controls.Add(this.treeList1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private System.Windows.Forms.BindingSource nTSDataSetBindingSource;
        private NTSDataSet nTSDataSet;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colReceivedTime;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAlarmCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAlarmHexCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAlarmHappen;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCategory;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colUnit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAlarmTextKorean;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAlarmTextChinese;
        private System.Windows.Forms.BindingSource alarmTableBindingSource;
    }
}

