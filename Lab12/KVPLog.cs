using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab12
{
    public class KVPLog
    {
        string path = @"D:\Work\CSharpLabs\Lab12\kvplogfile.txt";
        public void Write(string action, string obj, string date)
        {
            using (StreamWriter sw = new StreamWriter(@"D:\Work\CSharpLabs\Lab12\kvplogfile.txt", true))
            {
               sw.WriteLine($"Файл {obj} был {action} {date}");
            }

        }
    }
}
