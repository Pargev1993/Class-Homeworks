using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ISTC.codingschool.OOP.WorkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            foreach (var item in driveInfos)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.DriveType);
                if (item.IsReady)
                {
                    Console.WriteLine(item.TotalSize);
                    Console.WriteLine(item.TotalFreeSpace);
                    Console.WriteLine(item.VolumeLabel);
                }
            }

        }
    }
}
