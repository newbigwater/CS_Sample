using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleLogger : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
        }

        public void WriteLog(string format, params Object[] args)
        {
            string message = String.Format(format, args);
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger();
            logger.WriteLog("The world is not flat.");
            int a = 1;
            int b = a + a;
            logger.WriteLog($"{a} + {a} = {b}");
        }
    }
}
