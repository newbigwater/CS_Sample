using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncFileIO
{
    class Program
    {
        static long CopySync(string FromPath, string toPath)
        {
            using (var fromStream = new FileStream(FromPath, FileMode.Open))
            {
                long totalCopied = 0;
                using (var toStream = new FileStream(toPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024];
                    int nRead = 0;
                    while ((nRead = fromStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        toStream.Write(buffer, 0, nRead);
                        totalCopied += nRead;
                    }
                }

                return totalCopied;
            }
        }

        async static Task<long> CopyAsync(string FromPath, string ToPath)
        {
            using (var fromStream = new FileStream(FromPath, FileMode.Open))
            {
                long totalCopied = 0;

                using (var toStream = new FileStream(ToPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024];
                    int nRead = 0;
                    while ((nRead = await fromStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await toStream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;
                    }
                }

                return totalCopied;
            }
        }

        static async void DoCopy(string FromPath, string ToPath)
        {
            long totalCopied = await CopyAsync(FromPath, ToPath);
            Console.WriteLine($"Copied Total {totalCopied} Bytes.");
        }

        static void Main(string[] args)
        {
            Console.Write("From File Path : ");
            string FromPath = Console.ReadLine();
            Console.Write("To File Path : ");
            string ToPath = Console.ReadLine();

            DoCopy(FromPath, ToPath);
            Console.ReadLine();
        }
    }
}
