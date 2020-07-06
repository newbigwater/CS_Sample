using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Array_Int
    {
        private int[] array;

        public Array_Int()
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
                    Console.WriteLine($"array size : {array.Length}");
                }

                array[index] = value;
            }
        }
    }

    class Array_Generic<T>
    {
        private T[] array;

        public Array_Generic()
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
                    Console.WriteLine($"array<{array.GetType()}> size : {array.Length}");
                }

                array[index] = value;
            }
        }
    }

    class StructArray<T> where T : struct
    {
        public T[] Array { get; set; }

        public StructArray(int size)
        {
            Array = new T[size];
        }
    }

    class RefArray<T> where T : class
    {
        public T[] Array { get; set; }

        public RefArray(int size)
        {
            Array = new T[size];
        }
    }

    class Base { }
    class Derived : Base { }

    class BaseArray<U> where U : Base
    {
        public U[] Array { get; set; }

        public BaseArray(int size)
        {
            Array = new U[size];
        }

        public void CopyArray<T>(T[] Source) where T : U
        {
            Source.CopyTo(Array, 0);
        }
    }
    class Program
    {
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }
        static void Main(string[] args)
        {
            Array_Generic<int> intArr = new Array_Generic<int>();
            for (int i = 0; i <= 5; ++i)
            {
                intArr[i] = i + 1;
            }
            for (int i = 0; i <= 5; ++i)
            {
                Console.WriteLine($"{intArr[i]}");
            }

            StructArray<int> a = new StructArray<int>(3);
            for (int i = 0; i < 3; ++i)
                a.Array[i] = i + 1;

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            for(int i = 0; i < 3; ++i)
                b.Array[i] = new StructArray<double>(5 * (i+1));

            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived();
            d.Array[0] = CreateInstance<Derived>();
            d.Array[0] = CreateInstance<Derived>();

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray(d.Array);

        }
    }
}
