using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    class Newbigwater
    {
        public string name;
        public int age;

        [NonSerialized]
        public string phone;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stream ws = new FileStream("a.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();

            Newbigwater nbw = new Newbigwater();
            nbw.name = "tester";
            nbw.age = 123;
            nbw.phone = "123-123";
            Console.WriteLine($"name : {nbw.name}");
            Console.WriteLine($"age : {nbw.age}");
            Console.WriteLine($"phone : {nbw.phone}");

            serializer.Serialize(ws, nbw);
            ws.Close();

            Stream rs = new FileStream("a.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            Newbigwater nbw2 = deserializer.Deserialize(rs) as Newbigwater;
            rs.Close();

            Console.WriteLine($"name : {nbw2.name}");
            Console.WriteLine($"age : {nbw2.age}");
            Console.WriteLine($"phone : {nbw2.phone}");

            Console.ReadLine();
        }
    }
}

