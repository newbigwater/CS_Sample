using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlarmHistory
{
    public partial class AlarmHistoiry : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public AlarmHistoiry()
        {
            InitializeComponent();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
        }

        private void aceDesigner_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucDesigner.Instance))
            {
                container.Controls.Add(ucDesigner.Instance);
                ucDesigner.Instance.Dock = DockStyle.Fill;
            }

            //ucDesigner.Instance.ShowUserControl();
            ucDesigner.Instance.BringToFront();
        }

        private void aceViewer_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucViewer.Instance))
            {
                container.Controls.Add(ucViewer.Instance);
                ucViewer.Instance.Dock = DockStyle.Fill;
            }
            ucViewer.Instance.BringToFront();
        }
    }
}
