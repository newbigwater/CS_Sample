using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentences =
            {
                "EQP1 TABDFSDFG",
                " SDfasdf as34we EQP2",
                "sdfsadfeEQPEQP3dfsd23 sd"
            };

            for (int i = 0; i <= 3; ++i)
            {
                string pattern = $"EQP{i}";

                Console.WriteLine($"Pattern : {pattern} ------------------------------------------");
                foreach (var sentence in sentences)
                {
                    Console.WriteLine($"Target : {sentence}");
                    if (System.Text.RegularExpressions.Regex.IsMatch(sentence, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                    {
                        Console.WriteLine($"  (match for '{pattern}' found)");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
