using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab12
{
    public class KVPDirInfo
    {
        public string direpath;
        public DirectoryInfo dir;
        public KVPDirInfo(string direpath)
        {
            this.direpath = direpath;
            dir = new DirectoryInfo(direpath);
        }
        public void NumOfFiles()
        {
            FileInfo[] files = dir.GetFiles();
            
            string info = $"Количество файлов: {files.Length}";
            Console.WriteLine(info);
        }
        public void CreationTime()
        {
            string info = $"Время создания: {dir.CreationTime}";
            Console.WriteLine(info);
        }
        public void SubdirLength()
        {
            DirectoryInfo[] subdir = dir.GetDirectories();
            string info = $"Количестве поддиректориев: {subdir.Length} ";
            Console.WriteLine(info);
        }
        public void Parent()
        { 
            string info = $" Родительская директория: {dir.Parent}";
            Console.WriteLine(info);
        }
    }
}
