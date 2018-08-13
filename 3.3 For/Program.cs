using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Times to repeat: ");
            int times = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < times; i++)
            {
                Console.WriteLine($"Your name is {name}");
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
