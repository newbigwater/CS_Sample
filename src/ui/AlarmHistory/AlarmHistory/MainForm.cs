using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlarmHistory.Annotations;
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
            var unitList = ntsDataCtx.ExecuteQuery<AlarmHistoryTable>(
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
select dbo.AlarmTable.Unit, dbo.AlarmTable.Category, convert(varchar, dbo.AlarmTable.ReceivedTime, 120) as ReceivedTime, dbo.AlarmTable.AlarmCode, dbo.AlarmTable.AlarmHexCode, dbo.AlarmTable.AlarmTextKorean, dbo.AlarmTable.AlarmTextChinese, COUNT(dbo.AlarmTable.AlarmHexCode) as Count
from dbo.AlarmTable
where cast(dbo.AlarmTable.ReceivedTime AS DATE) = '2020-08-11' and dbo.AlarmTable.AlarmHappen = 1
group by dbo.AlarmTable.Unit, dbo.AlarmTable.Category, convert(varchar, dbo.AlarmTable.ReceivedTime, 120), dbo.AlarmTable.AlarmCode, .AlarmTable.AlarmHexCode, dbo.AlarmTable.AlarmTextKorean, dbo.AlarmTable.AlarmTextChinese
order by dbo.AlarmTable.Unit, dbo.AlarmTable.Category, convert(varchar, dbo.AlarmTable.ReceivedTime, 120), dbo.AlarmTable.AlarmCode;
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

            var tagetDataList = ntsDataCtx.ExecuteQuery<AlarmHistoryTable>(query);
            alarmHistoryTableBindingSource.DataSource = tagetDataList;
        }
    }
}
 
 