using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2_Watch_a_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            var watcher = new FileSystemWatcher();

            watcher.Path = @"c:\TMP";
            
            Console.WriteLine($"I'm watching this folder: {watcher.Path}");

            watcher.EnableRaisingEvents = true;

            watcher.Created += NewFile;
            watcher.Changed += ChangedFile;
            watcher.Renamed += RenamedFile;
            watcher.Deleted += RemovedFile;


            Console.ReadKey();
        }

        private static void RemovedFile(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.Name} removed");
        }

        private static void RenamedFile(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"File {e.Name} renamed");
        }
        private static void ChangedFile(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.Name} changed");
        }

        private static void NewFile(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.Name} created");
        }

    }
}
