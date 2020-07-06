using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncSample
{
    class Program
    {
        public static async void MyMethodAsync(int count)
        {
            Console.WriteLine("C");
            Console.WriteLine("D");

            await Task.Run(async () =>
            {
                for (int i = 1; i <= count; ++i)
                {
                    Console.WriteLine($"{i}/{count}...");
                    await Task.Delay(100);
                    //Task.Delay()는 Thread.Sleep()의 비동기 버전이라 할 수 있다.
                }
            });

            Console.WriteLine("G");
            Console.WriteLine("H");
        }

        static void caller()
        {
            Console.WriteLine("A");
            Console.WriteLine("B");

            MyMethodAsync(3);

            Console.WriteLine("E");
            Console.WriteLine("F");
        }
        static void Main(string[] args)
        {
            caller();
            Console.ReadLine();
        }
    }
}
