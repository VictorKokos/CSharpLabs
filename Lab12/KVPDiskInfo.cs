using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab12
{
    internal class KVPDiskInfo
    {
        string disk;
        DriveInfo drive;
        public KVPDiskInfo(string disk)
        {
            this.disk = disk;
            drive = new DriveInfo(disk);
        }
        public void FreeSpace()
        {
            string info = $"Свободное место: {drive.AvailableFreeSpace}";
            Console.WriteLine(info);
        }
        public void FileSystem()
        {
            string info = $"Файловая система: {drive.DriveFormat}";
            Console.WriteLine(info);
        }
        public static void AllInfo()
        {
            string info;
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                info = $"Имя: {drive.Name}; Объём: { drive.TotalFreeSpace}; доступный объем: " +
                     $"{ drive.AvailableFreeSpace}";
                Console.WriteLine(info);
            }
        }
    }
}
