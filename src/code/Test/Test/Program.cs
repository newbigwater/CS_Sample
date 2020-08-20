using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new object();
            test = Convert.ToInt32("123");

            Console.WriteLine($"{test}");
            Console.ReadLine();
        }
    }
}
