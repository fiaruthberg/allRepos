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

            int counter = 0;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            while(counter < times)
            {
                Console.WriteLine($"Your name is {name}");
                counter++;
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
