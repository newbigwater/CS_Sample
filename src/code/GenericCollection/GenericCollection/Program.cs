using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        private T[] array;
        private int position = -1;

        public MyList()
        {
            array = new T[3];
        }

        public T this[int index]
        {
            get { return array[index]; }
            set
            { 
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array({array.GetType()}) size : {array.Length}");
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get
            {
                return array.Length; 
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; ++i)
                yield return (array[i]);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < array.Length; ++i)
                yield return (array[i]);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (position == array.Length)
            {
                Reset();
                return false;
            }

            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public T Current => array[position];
        object IEnumerator.Current => array[position];
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < 5; ++i)
                list?.Add(i);
            foreach (var element in list)
            {
                Console.Write($"{element}");
            }
            Console.WriteLine();

            list.RemoveAt(2);
            foreach (var element in list)
            {
                Console.Write($"{element}");
            }
            Console.WriteLine();

            list.Insert(2, 2);
            foreach (var element in list)
            {
                Console.Write($"{element}");
            }
            Console.WriteLine();

            Queue<int> queue = new Queue<int>();
            for(int i = 0; i < 5; ++i)
                queue?.Enqueue(i);
            foreach (var element in queue)
            {
                Console.WriteLine($"{element.ToString()}");
            }
            Console.WriteLine();


            Stack<int> stack = new Stack<int>();
            for(int i = 0; i < 5; ++i)
                stack?.Push(i);
            foreach (var element in stack)
            {
                Console.WriteLine($"{element.ToString()}");
            }
            Console.WriteLine();

            Dictionary<string, int> dic = new Dictionary<string, int>();
            for(int i = 0; i < 5; ++i)
                dic.Add(i.ToString(), i);
            foreach (var element in dic)
            {
                Console.WriteLine($"{element.Key} {element.Value}");
            }
            Console.WriteLine();

            MyList<string> strList = new MyList<string>();
            strList[0] = "ABC";
            strList[1] = "DEF";
            strList[2] = "GHI";
            strList[3] = "JKL";
            strList[4] = "MNO";
            foreach (string element in strList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
