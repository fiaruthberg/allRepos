using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = AskForNumbers();
            if (ValidateNumbers(number))
            {
                PrintNumbers(number);
            }
        }

        private static bool ValidateNumbers(int number)
        {
            bool isAmultipleOfThree = number % 3 == 0;
            bool isAmultipleOfFive = number % 5 == 0;
            if (isAmultipleOfFive || isAmultipleOfThree)
            {
                return true;
            }

            return false;
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
    }
}

