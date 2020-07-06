using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationSample
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

            NTSDataContext dbCtx = new NTSDataContext();

            var alarmList =
                from alarm in dbCtx.AlarmTable
                where alarm.AlarmCode == 10
                select alarm;

            DateTime date = new DateTime(2020, 06, 16);
            var alarmList2 =
                from sensor1 in dbCtx.TM1_SENSOR1
                where sensor1.ReceivedTime.Month == date.Month
                select sensor1;

            dataGridView1.DataSource = alarmList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.DataSource = alarmList2;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
