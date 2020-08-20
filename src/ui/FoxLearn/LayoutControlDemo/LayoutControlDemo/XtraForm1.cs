using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LayoutControlDemo
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
        }

        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            try
            {
                layoutControl1.SaveLayoutToXml(string.Format($"{Application.StartupPath}/{this.Name}.xml"));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadLayout_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = string.Format($"{Application.StartupPath}/{this.Name}.xml");
                if (File.Exists(fileName))
                {
                    layoutControl1.RestoreLayoutFromXml(fileName);
                }
                else
                    XtraMessageBox.Show("없다.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}