using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace JsonParser
{
    public class ProtocolHead
    {
        public string date { get; set; }
        public string device { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ProtocolHead writehead = new ProtocolHead()
            {
                date = DateTime.Now.ToString(),
                device = "TEST1"
            };
            
            string jsonString = JsonConvert.SerializeObject(writehead, Formatting.Indented);
            Console.WriteLine($"{jsonString}");
            Console.ReadLine();
            
            
            ProtocolHead readHead = JsonConvert.DeserializeObject<ProtocolHead>(jsonString);
            readHead.date = DateTime.Now.ToString();
            string jsonString2 = JsonConvert.SerializeObject(readHead);
            Console.WriteLine($"{jsonString2}");
            Console.ReadLine();
        }
    }
}
