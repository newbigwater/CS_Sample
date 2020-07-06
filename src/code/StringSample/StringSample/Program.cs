using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "abcde abcde";
            Console.WriteLine(greeting);

            Console.WriteLine($"IndexOf : {greeting.IndexOf("a")}");
            Console.WriteLine($"LastIndexOf : {greeting.LastIndexOf("a")}");
        }
    }
}
