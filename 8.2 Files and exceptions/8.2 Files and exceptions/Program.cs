using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_Dividing_chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter a file name: ");

                try
                {
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    File.CreateText(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($"The file '{nameof (File)}' is now created.");
                    Console.WriteLine();
                    break;
                }
                catch (UnauthorizedAccessException)
                {
                    WriteInRed("You're not authorized to create this file");
                }
                catch (DirectoryNotFoundException)
                {
                    WriteInRed("Input output exception");
                }
                catch (ArgumentException)
                {
                    WriteInRed("The filename is not valid");
                }

            }

            File.AppendAllText(@"c:\TMP\bird.txt", "hej hopp");
        
        }

        private static void WriteInRed(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
