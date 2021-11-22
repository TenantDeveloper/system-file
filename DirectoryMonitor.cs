using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace File_System
{
    public static class  DirectoryMonitor
    {

        public static void Monitor(string directoryPath)
        {
            using var fileSystemWatcher = new FileSystemWatcher(directoryPath);
            fileSystemWatcher.IncludeSubdirectories = false;
            fileSystemWatcher.InternalBufferSize = 32768; // 32KB;
            fileSystemWatcher.Filter = "*.*"; // default value, and you can specify extension.
            fileSystemWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;

            fileSystemWatcher.Created += FileCreated;
            fileSystemWatcher.Changed += FileChanged;
            fileSystemWatcher.Deleted += FileDeleted;
            fileSystemWatcher.Renamed += FileRenamed;
            fileSystemWatcher.Error += WatcherError;

            fileSystemWatcher.EnableRaisingEvents = true;

            Console.WriteLine("Press Key to Quit");
            Console.ReadLine();
        }

        private static void WatcherError(object sender, ErrorEventArgs e)
        {
            Console.WriteLine($"error in file watcher ");
        }

        private static void FileRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"{e.Name}.{e.ChangeType} has been Renamed in {DateTime.Now}");
        }

        private static void FileDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"{e.Name}.{e.ChangeType} has been Deleted in {DateTime.Now}");
        }

        private static void FileChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"{e.Name}.{e.ChangeType} has been Changed in {DateTime.Now}");
        }

        private static void FileCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"{e.Name}.{e.ChangeType} has been Created in {DateTime.Now}");
        }
    }
}
