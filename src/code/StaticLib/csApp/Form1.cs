using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ClassLib;

namespace csApp
{
    public partial class Form1 : Form
    {
        [DllImport("ClassLib.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AddTest1(int a, int b);

        public Form1()
        {
           InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ClassLib.WrapStaticLib test = new WrapStaticLib();
            //edtResult.Text = test.Add(int.Parse(edtFir.Text), int.Parse(edtSec.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edtResult.Text = AddTest1(int.Parse(edtFir.Text), int.Parse(edtSec.Text)).ToString();
        }
    }
}
