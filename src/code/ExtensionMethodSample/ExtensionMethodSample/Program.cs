using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodSample
{
    public static class IntegerExtension
    {
        public static int Power(this int nInt, int exponent)
        {
            int result = nInt;
            for (int i = 0; i < exponent; ++i)
                result = result * nInt;

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            Console.WriteLine(a.Power(3));
        }
    }
}
