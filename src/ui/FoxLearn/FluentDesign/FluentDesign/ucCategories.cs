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

namespace FluentDesign
{
    public partial class ucCategories : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucCategories _instance;

        public static ucCategories Instance
        {
            get
            {
                if(null == _instance)
                    _instance = new ucCategories();
                return _instance;
            }
        }

        public ucCategories()
        {
            InitializeComponent();
        }

        private void ucCategories_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = new NTSEntities().TM1_SENSOR1.ToList();
        }
    }
}
