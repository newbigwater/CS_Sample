using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory;
            if (args.Length < 1)
                directory = ".";
            else
                directory = args[0];

            Console.WriteLine($"{directory} directory Info");
            Console.WriteLine($"- Directories :");
            var directories = (from dir in Directory.GetDirectories(directory)
                let info = new System.IO.DirectoryInfo(dir)
                select new
                {
                    name = info.Name,
                    Attributes = info.Attributes
                }).ToList();

            foreach(var d in directories)
                Console.WriteLine($"{d.name} : {d.Attributes}");

            Console.WriteLine("- Files : ");
            var files = (from file in Directory.GetFiles(directory)
                let info = new FileInfo(file)
                select new
                {
                    Name = info.Name,
                    FileSize = info.Length,
                    Attributes = info.Attributes
                }).ToList();

            foreach (var file in files)
            {
                Console.WriteLine($"{file.Name} : {file.FileSize}, {file.Attributes}");
            }
        }
    }
}
