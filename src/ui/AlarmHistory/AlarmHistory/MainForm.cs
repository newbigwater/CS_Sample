using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlarmHistory.Annotations;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using DateTime = System.DateTime;

namespace AlarmHistory
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();

            de_Start.DateTime = DateTime.Today.AddDays(-1);
            te_Start.Time = DateTime.Now;

            de_End.DateTime = DateTime.Now;
            te_End.Time = DateTime.Now;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var unitList = ntsDataCtx.ExecuteQuery<AlarmHistorySchema>(
                "select dbo.AlarmTable.Unit " +
                "from dbo.AlarmTable " +
                "group by dbo.AlarmTable.Unit " +
                "order by dbo.AlarmTable.Unit");

            eqpFilter.Properties.Items.Add("*");
            foreach (var alarmHistoryTable in unitList)
            {
                eqpFilter.Properties.Items.Add(alarmHistoryTable.Unit.ToString());
            }
            eqpFilter.SelectedIndex = 0;
        }

        ntsDataContext ntsDataCtx = new AlarmHistory.ntsDataContext();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            var startDateTime = new DateTime(de_Start.DateTime.Year, de_Start.DateTime.Month, de_Start.DateTime.Day, te_Start.Time.Hour, te_Start.Time.Minute, te_Start.Time.Second);
            var endDateTime = new DateTime(de_End.DateTime.Year, de_End.DateTime.Month, de_End.DateTime.Day, te_End.Time.Hour, te_End.Time.Minute, te_End.Time.Second);

            //             var tagetDataList = from tuple in ntsDataCtx.AlarmTable
            //                                 where startDateTime <= tuple.ReceivedTime
            //                                       && tuple.ReceivedTime <= endDateTime
            //                                 orderby tuple.ReceivedTime
            //                                 select tuple;

            /*
select dbo.AlarmTable.Unit, dbo.AlarmTable.Category, convert(smalldatetime, dbo.AlarmTable.ReceivedTime, 120) as ReceivedTime, dbo.AlarmTable.AlarmCode, dbo.AlarmTable.AlarmHexCode, dbo.AlarmTable.AlarmTextKorean, dbo.AlarmTable.AlarmTextChinese, COUNT(dbo.AlarmTable.AlarmHexCode) as Count
from dbo.AlarmTable
where cast(dbo.AlarmTable.ReceivedTime AS datetime) between '2020-08-11 13:20:00' and '2020-08-11 13:21:00'
	and dbo.AlarmTable.AlarmHappen = 1
group by dbo.AlarmTable.Unit, dbo.AlarmTable.Category, convert(smalldatetime, dbo.AlarmTable.ReceivedTime, 120), dbo.AlarmTable.AlarmCode, .AlarmTable.AlarmHexCode, dbo.AlarmTable.AlarmTextKorean, dbo.AlarmTable.AlarmTextChinese
order by dbo.AlarmTable.Unit, dbo.AlarmTable.Category, convert(smalldatetime, dbo.AlarmTable.ReceivedTime, 120), dbo.AlarmTable.AlarmCode;
             */
            string query = "select dbo.AlarmTable.Unit, dbo.AlarmTable.Category, convert(smalldatetime, dbo.AlarmTable.ReceivedTime, 120) as ReceivedTime, dbo.AlarmTable.AlarmCode, dbo.AlarmTable.AlarmHexCode, dbo.AlarmTable.AlarmTextKorean, dbo.AlarmTable.AlarmTextChinese, COUNT(dbo.AlarmTable.AlarmHexCode) as Count " +
                           "from dbo.AlarmTable " +
                           $"where convert(varchar, dbo.AlarmTable.ReceivedTime, 120) between '{startDateTime.ToString("yyyy-MM-dd HH:mm:ss")}' and '{endDateTime.ToString("yyyy-MM-dd HH:mm:ss")}' " +
                           "and dbo.AlarmTable.AlarmHappen = 1 ";

            if (!eqpFilter.Text.Equals("*"))
            {
                int unit = int.Parse(eqpFilter.Text);
                query += $"and dbo.AlarmTable.Unit = {unit} ";
            }

            if ("" != codeFilter.Text)
            {
                query += $"and dbo.AlarmTable.AlarmCode = {codeFilter.Text} ";
            }
            
            query +=
                $"group by dbo.AlarmTable.Unit, dbo.AlarmTable.Category, convert(smalldatetime, dbo.AlarmTable.ReceivedTime, 120), dbo.AlarmTable.AlarmCode, .AlarmTable.AlarmHexCode, dbo.AlarmTable.AlarmTextKorean, dbo.AlarmTable.AlarmTextChinese " +
                $"order by dbo.AlarmTable.Unit, dbo.AlarmTable.Category, convert(smalldatetime, dbo.AlarmTable.ReceivedTime, 120), dbo.AlarmTable.AlarmCode";


            alarmHistoryTableBindingSource.DataSource = ntsDataCtx.ExecuteQuery<AlarmHistorySchema>(query).ToList< AlarmHistorySchema>();
            var list = alarmHistoryTableBindingSource.DataSource as IEnumerable<AlarmHistorySchema>;
            var list2 = from alarm in list
                        group alarm by alarm.AlarmCode
                into grp
                       select new {GroupKey = grp.Key, alarms = grp};

            foreach (var arg in list2)
            {
                int i = 0;
                foreach (var alarm in arg.alarms)
                {
                    i++;
                }
            }
        }

        private void grdAlarmHistory_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
                pum_AlarmHistoryGrid.ShowPopup(Control.MousePosition);
        }
        

        private void ctcAlarmHistory_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                pum_AlarmHistoryChart.ShowPopup(Control.MousePosition);
        }

        private void barMgrAlarmHistoryGrid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string fileName = GetFilePath(e.Item.Caption, GetFilter(e.Item.Caption));
            if ("" == fileName)
                return;

            switch (e.Item.Caption)
            {
                case "Export to Excel":
                    {
                        grdAlarmHistory.ExportToXlsx(fileName);
                    }
                    break;
                case "Export to CSV":
                    {
                        grdAlarmHistory.ExportToCsv(fileName);
                    }
                    break;
                case "Export to DOCX":
                    {
                        grdAlarmHistory.ExportToDocx(fileName);
                    }
                    break;
                case "Export to HTML":
                    {
                        grdAlarmHistory.ExportToHtml(fileName);
                    }
                    break;
                case "Export to PDF":
                    {
                        grdAlarmHistory.ExportToPdf(fileName);
                    }
                    break;
            }
        }

        private void barMgrAlarmHistoryChart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string fileName = GetFilePath(e.Item.Caption, GetFilter(e.Item.Caption));
            if ("" == fileName)
                return;

            switch (e.Item.Caption)
            {
                case "Export to Excel":
                    {
                        ctcAlarmHistory.ExportToXlsx(fileName);
                    }
                    break;

                case "Export to IMG":
                    {   
                        ChartControl chart = (ChartControl)ctcAlarmHistory.Clone();
                        chart.Size = new Size(1200, 1200);
                        chart.ExportToImage(fileName, ImageFormat.Jpeg);
                        chart.Dispose();
                    }
                    break;

                case "Export to PDF":
                    {
                        ctcAlarmHistory.ExportToXlsx(fileName);
                    }
                    break;
            }
        }
        
        private string GetFilter(string type)
        {
            string filter = "";

            switch (type)
            {
                case "Export to Excel": filter = "XLSX |*.xlsx"; break;
                case "Export to CSV"  : filter = "CSV |*.csv"  ; break;
                case "Export to DOCX" : filter = "DOCX |*.docx"; break;
                case "Export to HTML" : filter = "HTML |*.html"; break;
                case "Export to PDF"  : filter = "PDF |*.pdf"  ; break;
                case "Export to IMG"  : filter = "JPG |*.jpg"  ; break;
            }

            return filter;
        }

        private string GetFilePath(string title, string filter)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog()
            {
                Title = title,
                Filter = filter
            };

            if (saveFileDlg.ShowDialog() != DialogResult.OK)
                return "";
            else
                return saveFileDlg.FileName;
        }
    }
}
 
 