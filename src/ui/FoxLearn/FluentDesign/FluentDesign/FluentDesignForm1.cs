using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Helpers;

namespace FluentDesign
{
    public partial class FluentDesignForm1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FluentDesignForm1()
        {
            InitializeComponent();
        }

        private void FluentDesignForm1_Load(object sender, EventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(Skins);
        }

        private void aceCategories_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucCategories.Instance))
            {
                container.Controls.Add(ucCategories.Instance);
                ucCategories.Instance.Dock = DockStyle.Fill;
            }
            ucCategories.Instance.BringToFront();
        }

        private void aceProducts_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucProducts.Instance))
            {
                container.Controls.Add(ucProducts.Instance);
                ucProducts.Instance.Dock = DockStyle.Fill;
            }
            ucProducts.Instance.BringToFront();
        }
    }
}
