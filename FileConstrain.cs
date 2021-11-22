using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace File_System
{
    public static class  FileConstrains
    {

        /// <summary>
        ///  check if file exist or not
        /// </summary>
        /// <param name="fileInput"></param>
        /// <returns></returns>
        public static bool IsFileExist(string filePath) => File.Exists(filePath);
        /// <summary>
        /// Check if directory exist or not
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <returns></returns>
        public static bool IsDirectoryExist(string directoryPath) => Directory.Exists(directoryPath);
    }
}
