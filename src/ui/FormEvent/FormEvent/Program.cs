using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEvent
{
    class Program : System.Windows.Forms.Form
    {
        private void Form_MouseHandler(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Console.WriteLine($"Sender : {((Form)sender).Text}");
            Console.WriteLine($"X:{e.X}, Y:{e.Y}");
            Console.WriteLine($"Button:{e.Button}, Clicks:{e.Clicks}");
            Console.WriteLine();
        }

        public Program(string titile)
        {
            this.Text = titile;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseHandler);
        }
        static void Main(string[] args)
        {
            Application.Run(new Program("Mouse Event Test"));
        }
    }
}
