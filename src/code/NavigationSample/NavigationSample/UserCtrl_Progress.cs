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
using DevExpress.XtraWaitForm;

namespace NavigationSample
{
    public partial class UserCtrl_Progress : WaitForm
    {
        public UserCtrl_Progress()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
        }
    }
}
