using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Working_with_different_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("What is your favorite character? ");
            char character = char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Thank you!");
            Console.WriteLine();

            int yearsUntilRetirement = 65 - age;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Your name is: {name}");
            Console.WriteLine($"You have {yearsUntilRetirement} years until retirement");
            if (char.IsNumber(character))
            {
                Console.WriteLine("You like numbers!");
            } else
            {
                Console.WriteLine("You don't like numbers");
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
