using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string plcConfigFilePath = Path.Combine(Environment.CurrentDirectory, @"setting.ini");
            // ini 쓰기
            IniFile ini = new IniFile();
            ini["WookoaSetting"]["TopAlways"] = "true";
            ini["WookoaSetting"]["ViewTray"] = "false";
            ini.Save(plcConfigFilePath);

            // ini 읽기
            ini.Load(plcConfigFilePath);
            string topAlways = ini["WookoaSetting"]["TopAlways"].ToString();
            string ViewTray = ini["WookoaSetting"]["ViewTray"].ToString();
        }
    }
}
