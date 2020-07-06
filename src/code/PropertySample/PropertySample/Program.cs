using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySample
{
    class Test
    {
        public string Name { get; set; } = "Unknown";

        public int Age
        {
            get { return Age; }
            set { Age = value; }
        }
    }

    interface IProduct
    {
        string Name { get; set; }
    }

    class Computer : IProduct
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Age = 1;
        }
    }
}
