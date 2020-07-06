using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample
{
#if _EX01
    class MyClass
    {
        [Obsolete("OldMethod는 폐기되었습니다. NewMethod()를 이용하세요.")]
        public void OldMethod()
        {
            Console.WriteLine("I'm old.");
        }

        public void NewMethod()
        {
            Console.WriteLine("I'm new.");
        }
    }
#endif

#if _EX02
    public static class Trace
    {
        public static void WriteLine(string message,
            [CallerFilePath] string file = "",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = ""
        )
        {
            Console.WriteLine($"{file}  {line}  {member} : {message}");
        }
    }
#endif
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    class History : System.Attribute
    {
        private string programmer;

        public double Version { get; set; }
        public string Changes { get; set; }

        public History(string programmer)
        {
            this.programmer = programmer;
            Version = 1.0;
            Changes = "First release";
        }

        public string Programmer
        {
            get { return programmer; }
        }
    }

    [History("NEW", Version = 0.1, Changes = "2020-06-18 Created class stub")]
    [History("NEW", Version = 1.1, Changes = "2020-06-19 Added Func() Method")]
    class MyClass
    {
        public void Func()
        {
            Console.WriteLine("Func()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
#if _EX01
            MyClass obj = new MyClass();
            obj.OldMethod();
            obj.NewMethod();
#endif
#if _EX02
            Trace.WriteLine("즐거운 프로그래밍");      
#endif
            Type type = typeof(MyClass);

            Attribute[] attList = Attribute.GetCustomAttributes(type);
            foreach (var element in attList)
            {
                History h = element as History;
                if (null != h)
                    Console.WriteLine($"Ver:{h.Version}, " +
                                      $"Programmer:{h.Programmer}, " +
                                      $"Changes:{h.Changes}"
                    );
            }

        }
    }
}
