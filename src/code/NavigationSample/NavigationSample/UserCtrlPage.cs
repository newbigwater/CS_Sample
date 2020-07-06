using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using MPC.Views;

namespace NavigationSample
{
    public partial class UserCtrlPage : UserControl
    {
        public UserCtrlPage()
        {
            InitializeComponent();
        }
        private static UserCtrlPage _instance = null;
        public static UserCtrlPage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserCtrlPage();
                }
                return _instance;
            }
        }

        public void ShowUserControl()
        {
            NTSDataContext dbCtx = new NTSDataContext();

            var alarmList =
                from alarm in dbCtx.AlarmTable
                where alarm.AlarmCode == 10
                select alarm;

            dataGridView1.DataSource = alarmList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
