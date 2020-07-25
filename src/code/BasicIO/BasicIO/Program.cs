using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicIO
{
    class Program
    {
        static void Main(string[] args)
        {
            long someValue = 0x123456789ABCDEF0;
            Console.WriteLine($"{"Original Data",-1} : 0x{someValue:X16}");

            Stream outStream = new FileStream("a.dat", FileMode.Create);
            byte[] wBytes = BitConverter.GetBytes(someValue);

            Console.Write($"{"Byte array", -13}");
            foreach (var wByte in wBytes)
            {
                Console.Write($"{wByte:x2}");
            }
            Console.WriteLine();

            outStream.Write(wBytes, 0, wBytes.Length);
            outStream.Close();

            Stream inStream = new FileStream("a.dat", FileMode.Open);
            byte[] rbytes = new byte[8];

            int i = 0;
            while (inStream.Position < inStream.Length)
            {
                rbytes[i++] = (byte) inStream.ReadByte();
            }

            long readValue = BitConverter.ToInt64(rbytes, 0);
            Console.WriteLine($"{"Read Data", -13} : 0x{readValue:x16}");
            inStream.Close();

            Console.ReadLine();
        }
    }
}
