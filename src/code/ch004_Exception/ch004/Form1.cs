using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                testFunc();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());

            }
        }

        private double testFunc()
        {
            try
            {
                throw new Exception("1");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

                throw new Exception("2");
            }

            return 0.5;
        }
    }
}
