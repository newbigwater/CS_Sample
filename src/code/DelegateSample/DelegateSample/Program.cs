using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    delegate int Calculate(int a, int b);
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    delegate int Compare<T>(T a, T b);
    class Program
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            Console.WriteLine("AscendCompare");
            return a.CompareTo(b);
        }

        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            Console.WriteLine("DescendCompare");
            return a.CompareTo(b) * -1;
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> comparer)
        {
            int i = 0, j = 0;
            T temp;

            for (i = 0; i < DataSet.Length; ++i)
            {
                for (j = 0; j < DataSet.Length - (i + 1); ++j)
                {
                    if (comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        delegate void Notify(string message);

        class Notifier
        {
            public Notify EventOccured;
        }

        class EventListener
        {
            private string name;

            public EventListener(string name)
            {
                this.name = name;
            }

            public void SomethingHappend(string message)
            {
                Console.WriteLine($"{name}.SomethingHappened : {message}");
            }
        }
        
        public void SomethingHappend(string message)
        {
            Console.WriteLine($"TEST.SomethingHappened : {message}");
        }
        static void Main(string[] args)
        {
            Calculate Calc;
            Calc = new Calculate(Calculator.Plus);
            Console.WriteLine($"1 + 1 = {Calc(1, 1)}");
            Calc = new Calculate(Calculator.Minus);
            Console.WriteLine($"1 - 1 = {Calc(1, 1)}");

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Defore");
            int[] array = {3, 7, 4, 2, 10};
            foreach (var element in array)
            {
                Console.Write(element);
            }
            Console.WriteLine();

            Console.WriteLine("-------------");
            Compare<int> comp = new Compare<int>(AscendCompare);
            comp += new Compare<int>(DescendCompare);
            BubbleSort(array, comp);
            foreach (var element in array)
            {
                Console.Write(element);
            }
            Console.WriteLine();
            Console.WriteLine("-------------");

            Console.WriteLine("Sorting ascending...");
            BubbleSort(array, new Compare<int>(AscendCompare));
            foreach (var element in array)
            {
                Console.Write(element);
            }
            Console.WriteLine();

            Console.WriteLine("Sorting descending...");
            BubbleSort(array, new Compare<int>(DescendCompare));
            foreach (var element in array)
            {
                Console.Write(element);
            }
            Console.WriteLine();

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            Notifier notifier = new Notifier();
            EventListener a = new EventListener("a");
            EventListener b = new EventListener("b");
            EventListener c = new EventListener("c");

            notifier.EventOccured += a.SomethingHappend;
            notifier.EventOccured += b.SomethingHappend;
            notifier.EventOccured += c.SomethingHappend;
            notifier.EventOccured += SomethingHappend;//new Notify(SomethingHappend);
            notifier.EventOccured("You've got mail.");

            Console.WriteLine();

            notifier.EventOccured -= b.SomethingHappend;
            notifier.EventOccured("Download complete.");

            Console.WriteLine();

            notifier.EventOccured = new Notify(b.SomethingHappend)
                                    + new Notify(c.SomethingHappend);
            notifier.EventOccured("Nuclear launch detected.");

            Console.WriteLine();

            Notify notify1 = new Notify(a.SomethingHappend);
            Notify notify2 = new Notify(b.SomethingHappend);
            notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
            notifier.EventOccured("Fire.");

            Console.WriteLine();

            notifier.EventOccured =
                (Notify) Delegate.Remove(notifier.EventOccured, notify2);
            notifier.EventOccured("RPG!");
            Console.WriteLine();

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            /// 

        }
    }
}
