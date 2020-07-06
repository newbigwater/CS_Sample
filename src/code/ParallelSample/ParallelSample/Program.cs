using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSample
{
    class Program
    {
        static bool IsPrime(long number)
        {
            if (number < 2)
                return false;

            if (number % 2 == 0 && number != 2)
                return false;

            for (long i = 2; i < number; ++i)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("From : ");
            long from = (long)Convert.ToInt32(Console.ReadLine());
            Console.Write("To : ");
            long to = (long)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please press enter to start...");
            Console.ReadLine();
            Console.WriteLine("Started...");

            DateTime startTime = DateTime.Now;

            List<long> total = new List<long>();
            Parallel.For(from, to, (long i) =>
                {
                    if(IsPrime(i))
                        total.Add(i);
                }
            );

            DateTime endTime = DateTime.Now;

            TimeSpan ellapsed = endTime - startTime;
            Console.WriteLine($"Prime number count between {from} and {to} : {total.Count}");
            Console.WriteLine($"Ellapsed time : {ellapsed}");
        }
    }
}
