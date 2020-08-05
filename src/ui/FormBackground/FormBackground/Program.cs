using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBackground
{
    class Program : System.Windows.Forms.Form
    {
        private Random rand;

        public Program()
        {
            rand = new Random();

            this.MouseWheel += new MouseEventHandler(Prog_MouseWheel);
            this.MouseDown += new MouseEventHandler(Prog_MouseDown);
        }

        void Prog_MouseWheel(object sender, MouseEventArgs e)
        {
            this.Opacity = this.Opacity += (e.Delta > 0 ? 0.1 : -0.1);
            Console.WriteLine($"Opacity : {this.Opacity}");
        }

        void Prog_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Color oldColor = this.BackColor;
                this.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (this.BackgroundImage != null)
                { 
                    this.BackgroundImage = null;
                    return;
                }

                string file = "test.jpg";
                if (System.IO.File.Exists(file) == false)
                    MessageBox.Show("이미지 파일이 존재 하지 않습니다.");
                else
                {
                    this.BackgroundImage = Image.FromFile(file);
                }
            }

        }

        static void Main(string[] args)
        {
            Application.Run(new Program());
        }
    }
}
