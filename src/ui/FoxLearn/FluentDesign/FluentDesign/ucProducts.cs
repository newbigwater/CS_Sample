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
    public partial class ucProducts : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucProducts _instance;

        public static ucProducts Instance
        {
            get
            {
                if (null == _instance)
                    _instance = new ucProducts();
                return _instance;
            }
        }

        public ucProducts()
        {
            InitializeComponent();
        }

        private void ucProducts_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = new NTSEntities().TM2_SENSOR1.ToList();
        }
    }
}
