using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitListView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 운영체제에 설치되어 있는 폰트 목록 검색
            foreach (var fontFamily in FontFamily.Families)
            {
                cboFont.Items.Add(fontFamily.Name);
            }

            cboFont.SelectedIndex = 0;
        }

        private void ChangeFont(object sender, EventArgs e)
        {
            if (cboFont.SelectedIndex < 0)
                return;

            FontStyle style = FontStyle.Regular;

            if (chkBold.Checked)
                style |= FontStyle.Bold;

            if (chkItalic.Checked)
                style |= FontStyle.Italic;

            txtSampleText.Font = new Font((string)cboFont.SelectedItem, 10, style);
        }

        private void ScrollEventHandler(object sender, EventArgs e)
        {
            pgDummy.Value = tbDummy.Value;
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Red;
            frm.ShowDialog();
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modaless form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Green;
            frm.Show();
        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text, "MessageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        Random random = new Random(37);

        private void InitListView()
        {
            lvDummy.Columns.Add("Name");
            lvDummy.Columns.Add("Depth");
        }
        private void TreeToList()
        {
            lvDummy.Items.Clear();
            foreach (TreeNode tvDummyNode in tvDummy.Nodes)
            {
                TreeToList(tvDummyNode);
            }
        }

        private void TreeToList(TreeNode node)
        {
            lvDummy.Items.Add(
                new ListViewItem(
                    new string[]
                    {
                        node.Text, node.FullPath.Count(f => f == '\\').ToString()
                    }));

            foreach (TreeNode tmpNode in node.Nodes)
            {
                TreeToList(tmpNode);
            }
        }

        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if (tvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.",
                    "TreeView Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            tvDummy.SelectedNode.Expand();
            TreeToList();
        }
    }
}
