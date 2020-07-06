using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using log4net.Appender;
using log4net.Layout;
using log4net.Repository.Hierarchy;

namespace Log4NetSample
{
    class Program
    {

        static void Main(string[] args)
        {
            new Program();
            Console.WriteLine("Press Any Key...");
            Console.ReadKey();
        }

        public Program()
        {
            ILog log1 = LogManager.GetLogger("NBW1");
            ILog log2 = LogManager.GetLogger("NBW2");

            log1.Debug("debug");
            log1.Info("info");
            log1.Warn("warn");
            log1.Error("error");
            log1.Fatal("fatal");

            log2.Debug("debug");
            log2.Info("info");
            log2.Warn("warn");
            log2.Error("error");
            log2.Fatal("fatal");
        }
    }
}
