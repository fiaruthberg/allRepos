using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pandor
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = GetUserInput();
            if (ValidateUserInput(input))
            {
                GreetUser(input);
            }
            int number = AskForNumbers();
            PrintNumbers(number);
        }

        private static void PrintNumbers(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{i}");
            }
        }

        private static int AskForNumbers()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        private static bool ValidateUserInput(string input)
        {
            if (!Regex.IsMatch(input, @"^\s*(alice|bob)\s*$", RegexOptions.IgnoreCase))
            {
                return false;
            }
            return true;
        }

        private static string GetUserInput()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        private static void GreetUser(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
