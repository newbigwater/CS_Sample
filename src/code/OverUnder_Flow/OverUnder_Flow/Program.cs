using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverUnder_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);

            int b = int.MinValue;
            Console.WriteLine(b);
            b--;
            Console.WriteLine(b);

            int? c = null;
            Console.WriteLine(c.HasValue);
            Console.WriteLine(c != null);
        }
    }
}
