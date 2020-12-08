using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddLib
{
    public class AddClass : IDisposable
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int minus(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return add(a, b);
        }

        public void Dispose()
        {
        }
    }
}
