using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class TestClass
    {
        public int num { get; set; } = 0;
    }

    class TestClassFir : TestClass
    {

    }

    [Flags]
    public enum DIRECTION_TYPE
    {
        Unknown = -1,
        Top = 1,
        Left = Top << 1,
        Right = Left << 1,
        Bottom = Right << 1
    }

    class Program
    {
        TestClassFir testClasfir = new TestClassFir();
        public static void GetEnumerate<T>(string fir, out T sec) where T : struct
        {
            try
            {
                Enum.TryParse(fir, true, out sec);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static T GetEnumerate<T>(string fir) where T : struct
        {
            try
            {
                T tEnum;
                Enum.TryParse(fir, true, out tEnum);
                return tEnum;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void TestFunction(TestClass testClass)
        {
            testClass.num++;
        }

        static void Main(string[] args)
        {
            Program test1 = new Program();
            test1.TestFunction(test1.testClasfir);
            test1.TestFunction(test1.testClasfir);
            test1.TestFunction(test1.testClasfir);

            //             DIRECTION_TYPE testEnum = DIRECTION_TYPE.Unknown;
            //             GetEnumerate<DIRECTION_TYPE>("Top, Left", out testEnum);
            //             GetEnumerate<DIRECTION_TYPE>("Top", out testEnum);
            //             testEnum = GetEnumerate<DIRECTION_TYPE>("Right");
            //             testEnum = GetEnumerate<DIRECTION_TYPE>("Right, Bottom");
            // 
            //             string stringTest = "ABC";
            //             string subStringTest0 = stringTest.Substring(1);
            //             string subStringTest1 = stringTest.Substring(2);
            //             string subStringTest2 = stringTest.Substring(3);
            // 
            //             DIRECTION_TYPE test = DIRECTION_TYPE.Top;
            //             if ((DIRECTION_TYPE.Top | DIRECTION_TYPE.Left) == DIRECTION_TYPE.Top)
            //             Console.WriteLine($"{DIRECTION_TYPE.Top | DIRECTION_TYPE.Left} : {(int)(DIRECTION_TYPE.Top | DIRECTION_TYPE.Left)}");
            //             for (int i = 1; i <= 20; ++i)
            //             {
            //                 Console.WriteLine($"{(DIRECTION_TYPE)i}");
            //             }
            // 
            //             CancellationTokenSource _cts = new CancellationTokenSource();
            //             ParallelOptions _po = new ParallelOptions();
            // 
            //             _po.CancellationToken = _cts.Token;
            //             _po.MaxDegreeOfParallelism = System.Environment.ProcessorCount;
            //             Parallel.For(0, 1000, (i) =>
            //             {
            //                 Console.WriteLine("{0}: {1}",
            //                     Thread.CurrentThread.ManagedThreadId, i);
            //             });
            // 
            //             System.Console.ReadLine();
        }
    }
}
