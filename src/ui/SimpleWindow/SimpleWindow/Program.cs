using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWindow
{
    class Program : System.Windows.Forms.Form
    {
        static void Main(string[] args)
        {
            Program form = new Program();
            form.Click += new EventHandler((sender, eventArgs) =>
            {
                Console.WriteLine("Closing Window...");
                Application.Exit();
            });

            Console.WriteLine("Starting Window Application...");`
            Application.Run(form);
            
            Console.WriteLine("Exiting Window Application...");
            Console.ReadLine();
        }
    }
}
