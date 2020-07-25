using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFile_ReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create));
            bw.Write(int.MaxValue);
            bw.Write("Good J-One");
            bw.Write(uint.MinValue);
            bw.Write("NewBigWater");
            bw.Write(Double.MaxValue);
            bw.Close();

            BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));
            Console.WriteLine($"File Size : {br.BaseStream.Length} bytes");
            Console.WriteLine($"{br.ReadInt32()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadUInt32()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadDouble()}");
            br.Close();

            Console.ReadLine();
            */

            StreamWriter sw = new StreamWriter(new FileStream("a.dat", FileMode.Create));
            sw.WriteLine(int.MaxValue);
            sw.WriteLine("Good J-One");
            sw.WriteLine(uint.MinValue);
            sw.WriteLine("NewBigWater");
            sw.WriteLine(Double.MaxValue);
            sw.Close();

            StreamReader sr = new StreamReader(new FileStream("a.dat", FileMode.Open));
            Console.WriteLine($"File Size : {sr.BaseStream.Length} bytes");
            while(sr.EndOfStream == false)
                Console.WriteLine(sr.ReadLine());
            sr.Close();

            Console.ReadLine();
        }
    }
}
