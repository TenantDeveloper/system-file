using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace File_System
{
    public class FileProcessor
    {
        private string fileInput;
        public FileProcessor(string fileInput)
        {
            this.fileInput = fileInput;
        }
        public FileProcessor()
        {

        }

        public void Process ()
        {
            if (string.IsNullOrEmpty(fileInput)) return;

            Console.WriteLine("Being -> Process");

            // check if file not exist.
            if (!File.Exists(fileInput)) 
            {
                Console.WriteLine($"{fileInput} not exist");
                return;
            }

            var parentInput = new DirectoryInfo(fileInput);


        }

        /// <summary>
        ///  Create folder.
        /// </summary>
        /// <param name="rootPath"></param>
        /// <param name="folderName"></param>
        public void CreateFolder(string rootPath , string folderName)
        {
            string folderPath = Path.Combine(rootPath, folderName);
            if(!FileConstrains.IsDirectoryExist(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Folder Created Successfully !");
            }
        }


        public void CopyFile(string fromPath , string toPath , bool overWriteFile = false)
        {
            var fileName = Path.GetFileName(fromPath);
            var fileCopingPath = Path.Combine(toPath, fileName);
            Console.WriteLine("Coping Running ...");
            try
            {
                File.Copy(fromPath, fileCopingPath , overWriteFile);
                Console.WriteLine("File copied");
            }
            catch (IOException _)
            {

                Console.WriteLine("File is exist before, your can overwrite ");
            }
           
        }


        public void MoveFile(string fromPath , string toPath , bool overWriteFile = false)
        {
            var fileName = Path.GetFileName(fromPath);
            var fileMovedPath = Path.Combine(toPath, fileName);
            Console.WriteLine("Moving File Running...");
            File.Move(fromPath, fileMovedPath, overWriteFile);
        }
    }
}
