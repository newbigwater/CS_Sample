using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            NBWDataContext db = new NBWDataContext();

            var dataSet =
                from data in db.AlarmTable
                select data;

            foreach (var data in dataSet)
                Console.WriteLine($"{data.AlarmTextKorean}");
        }
    }
}
