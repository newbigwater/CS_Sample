using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;


namespace Attribute_CallerInfo
{
    [System.AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class History : System.Attribute
    {
        public string Programmer { get; set; }
        public string Version { get; set; }

        public History()
        {
            this.Programmer = "First";
            this.Version = "1.0.0.1";
        }
        public History(string _programmer)
        {
            this.Programmer = _programmer;
            this.Version = "1.0.0.1";         
        }
    }

    [History(Programmer = "TESER1", Version = "1.0.0.1")]
    [History("TESER2", Version = "1.0.0.2")]
    [History("TESER0", Version = "1.0.0.0")]
    public class Trace
    {
        public void Func(
            string message,
            [CallerFilePath] string file = "",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = "")
        {
            Attribute[] attrArray = Attribute.GetCustomAttributes(this.GetType());
            foreach (var attr in attrArray)
            {
                History _his = attr as History;
                if(null != _his)
                {
                    Console.WriteLine($"[Ver:{_his.Version}][Prg:{_his.Programmer}]");
                }
            }

            Console.WriteLine($"[{file}][{line}][{member}] : {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trace tr = new Trace();
            tr.Func("TEST");

            Console.ReadLine();
        }
    }
}
