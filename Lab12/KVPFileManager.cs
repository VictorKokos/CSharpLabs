using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace Lab12
{
    public class KVPFileManager
    {
        public void DirInfo (string diskname, string dirinfopath)
        {
            DirectoryInfo drive = new(diskname);
            DirectoryInfo[] subdirs = drive.GetDirectories();
            FileInfo[] files = drive.GetFiles();

            using(StreamWriter sw = new StreamWriter(dirinfopath, false))
            {
                foreach (DirectoryInfo dir in subdirs)
                {
                    sw.WriteLine(dir.FullName);
                }
                foreach (FileInfo file in files)
                {
                    sw.WriteLine(file.FullName);
                }
            }

        }
        public void CopyAndDel(KVPFileInfo file, string copyFolder)
        {
            file.file.CopyTo(copyFolder);
            KVPLog log = new KVPLog();
            DateTime dateTime = new DateTime();
            log.Write("Скопирован", file.file.Name, DateTime.Now.ToString());
            file.file.Delete();
            log.Write("Удалён", file.file.Name, DateTime.Now.ToString());
        }

        public void CopyToKVPFiles(KVPDirInfo dir, string format)
        {
            FileInfo[] filesfromdir = dir.dir.GetFiles();
            filesfromdir = filesfromdir.Where(f => f.Extension == format).ToArray();
            KVPLog log = new KVPLog();
            DateTime dateTime = new DateTime();
            foreach (FileInfo file in filesfromdir)
            {
                file.CopyTo(@$"D:\Work\CSharpLabs\Lab12\KVPFILES\{file.Name}");
                log.Write("Скопирован", file.Name, DateTime.Now.ToString());
                file.MoveTo(@$"D:\Work\CSharpLabs\Lab12\KVPINSPECT\{file.Name}");
                log.Write("Перемещён", file.Name, DateTime.Now.ToString());
            }

        }
     


    }
}
