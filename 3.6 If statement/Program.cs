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

            Console.Write("Enter a number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter a second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;


            if (number1 < number2)
            {                
                Console.WriteLine($"{number1} is lower than {number2}");
            } else if (number1 == number2)
            {
                Console.WriteLine($"{number1} is equal to {number2}");
            } else
            {
                Console.WriteLine($"{number1} is higher than {number2}");
            }
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
