using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;

namespace SkinDemo
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(SkinsLink);

            foreach (SkinContainer cn in SkinManager.Default.Skins)
            {
                cboSkins.Properties.Items.Add(cn.SkinName);
            }
        }

        private void cboSkins_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(cboSkins.Text);
        }
    }
}