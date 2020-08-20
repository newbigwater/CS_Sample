using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace AlarmHistory
{
    public partial class ucDesigner : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucDesigner _instance;
        private string _filePath = "";
        private bool _bInit = false;

        public static ucDesigner Instance
        {
            get
            {
                if(null == _instance)
                    _instance = new ucDesigner();
                return _instance;
            }
        }

        public ucDesigner()
        {
            InitializeComponent();

            _filePath = string.Format(@"Configuration/DashBoard/AlarmDashBoard.xml");
        }

        private void dashboardDesigner1_ConfigureDataConnection(object sender, DevExpress.DashboardCommon.DashboardConfigureDataConnectionEventArgs e)
        {

        }

        public void ShowUserControl()
        {
            InitData();

            dashboardDesigner1.ReloadData();

            dashboardDesigner1.BeginUpdateParameters();
            dashboardDesigner1.Parameters["StartDate"].SelectedValue = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            dashboardDesigner1.Parameters["EndDate"].SelectedValue = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day + 1);
            dashboardDesigner1.EndUpdateParameters();
        }

        private void InitData()
        {
            try
            {
//                 var curShow = CurLoginStatus.Instance.bToolbarShow;
// 
//                 ShowStyle(curShow);

                if (_bInit == false)
                {
                    dashboardDesigner1.LoadDashboard(_filePath);
                    _bInit = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void ShowStyle(bool show)
        {
            try
            {
                if (show)
                {
                    var firstView = (SplitContainerControl)dashboardDesigner1.Controls[0];
                    firstView.PanelVisibility = SplitPanelVisibility.Both;

                    var secondView = (SplitContainerControl)firstView.Panel2.Controls[0];
                    secondView.PanelVisibility = SplitPanelVisibility.Both;

                    ribbonControl1.Show();
                }
                else
                {
                    var firstView = (SplitContainerControl)dashboardDesigner1.Controls[0];
                    firstView.PanelVisibility = SplitPanelVisibility.Panel2;
                    var secondView = (SplitContainerControl)firstView.Panel2.Controls[0];
                    secondView.PanelVisibility = SplitPanelVisibility.Panel2;

                    ribbonControl1.Hide();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void dashboardDesigner1_PopupMenuShowing(object sender, DevExpress.DashboardWin.DashboardPopupMenuShowingEventArgs e)
        {

        }
    }
}
