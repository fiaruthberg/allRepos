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

            Console.Write("Columns: ");
            int columns = int.Parse(Console.ReadLine());

            Console.Write("Rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < rows; i++)
            {
                
                for (int j = 1; j < columns; j++)
                {
                    Console.Write($"Your name is {name}     ");
                }
                Console.Write($"Your name is {name}     ");
                Console.WriteLine();

            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
