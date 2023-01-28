using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab12
{
    public class KVPFileInfo
    {
        public string filepath;
       public FileInfo file;
        public KVPFileInfo(string filepath)
        {
            this.filepath = filepath;
            file = new FileInfo(filepath);
        }
        public void FullPath()
        {
            string info = $"Полный путь: {file.FullName}";
            Console.WriteLine(info);
        }
        public void NameInf()
        {
            string info = $"Имя: {file.Name}; Расширение:{file.Extension};Размер:{file.Length} ";
            Console.WriteLine(info);
        }
        public void Dates()
        {
            string info = $"Дата создания: {file.CreationTime}; Дата изменения: {file.LastWriteTime} ";
            Console.WriteLine(info);
        }
    }
}
