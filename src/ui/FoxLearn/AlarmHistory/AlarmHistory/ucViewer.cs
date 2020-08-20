using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AlarmHistory
{
    public partial class ucViewer : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucViewer _instance;

        public static ucViewer Instance
        {
            get
            {
                if(null == _instance)
                    _instance = new ucViewer();
                return _instance;
            }
        }

        public ucViewer()
        {
            InitializeComponent();
        }
    }
}
