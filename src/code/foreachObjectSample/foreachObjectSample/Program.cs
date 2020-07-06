using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace foreachObjectSample
{
    class MyEnumerator
    {
        private int[] numbers = {1, 2, 3, 4, 5};

        public IEnumerator GetEnumerator()
        {
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;
            /*
             yield break는 GetEnumerator() 메소드를
             종료 시킴으로 아래 코드는 실행되지 않는다.
             */
            yield return numbers[3];
            yield return numbers[4];
        }
    }

    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        public object Current
        {
            get { return array[position]; }
        }

        public bool MoveNext()
        {
            if (position == array.Length - 1)
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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; ++i)
                yield return (array[i]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var Inst = new MyEnumerator();
            foreach (var obj in Inst)
                Console.WriteLine(obj);
                */
            MyList list = new MyList();
            for (int i = 0; i < 5; ++i)
                list[i] = i;

            foreach(var a in list)
                Console.WriteLine(a);
        }
    }
}
