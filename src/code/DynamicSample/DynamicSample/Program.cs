using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSample
{
#if _EX01
    class MyClass
    {
        public void FuncAAA()
        {
            // do nothing
        }
    }
#endif

    class Duck
    {
        public void Walk() { Console.WriteLine("Duck.Walk");}
        public void Swim() { Console.WriteLine("Duck.Swim"); }
        public void Quack() { Console.WriteLine("Duck.Quack"); }
    }

    class Mallard : Duck
    {
    }

    // Robot도 오리다.
    class Robot
    {
        public void Walk() { Console.WriteLine("Robot.Walk"); }
        public void Swim() { Console.WriteLine("Robot.Swim"); }
        public void Quack() { Console.WriteLine("Robot.Quack"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
#if _EX01
            dynamic obj = new MyClass();
            obj.FuncAAA();
            
            // dynamic 형식으로 선언된 boj는 일단 컴파일러 형식 검사는 피해갑니다.
            obj.FuncBBB();
#endif

            dynamic[] arr = new dynamic[] {new Duck(), new Mallard(), new Robot()};
            foreach (dynamic duck in arr)
            {
                Console.WriteLine(duck.GetType());

                duck.Walk();
                duck.Swim();
                duck.Quack();

                Console.WriteLine();
            }
        }
    }
}
