using System;
using System.IO;

namespace File_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the file Path");
            //var filePath = Console.ReadLine();

            //var fileProcessor = new FileProcessor(filePath);
            //fileProcessor.Process();
            //Console.WriteLine("Driver availabe on this disk: ");
            //foreach (var item in DriveInfo.GetDrives())
            //{
            //    Console.WriteLine(item.Name);
            //}
            //var fileProcessor = new FileProcessor();

            //Console.WriteLine("Enter the root path");
            //var rootPath = Console.ReadLine();
            //Console.WriteLine("Enter the folder name");
            //var folderName = Console.ReadLine();
            //var fileProcessor = new FileProcessor();
            //fileProcessor.CreateFolder(rootPath, folderName);

            //Console.WriteLine("Enter File Path you want to copy it :");
            //var pathReadyToCopy = Console.ReadLine();

            //Console.WriteLine("Enter Path you want to copy to it :");
            //var toPath = Console.ReadLine();

            //fileProcessor.CopyFile(pathReadyToCopy, toPath);


            Console.WriteLine("Folder Monitor ................................................");

            Console.WriteLine("Enter Folder you want to monitor it");
            var directoryPath = Console.ReadLine();
            if(!Directory.Exists(directoryPath))
            {
                Console.WriteLine("folder not exist");
                return;
            }

            DirectoryMonitor.Monitor(directoryPath);
           
        }
    }
}
