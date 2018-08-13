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

            Random random = new Random();

            int returnValue = random.Next(1, 100);
            int guesses = 0;

            Console.WriteLine("I am thinking of a number between 1-100. You have 6 guesses. Can you guess what it is?");

            Console.WriteLine();

            while (guesses < 6)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

               


                if (returnValue == number)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Well done! The answer was {returnValue}");
                    break;
                }
                else if (number < returnValue)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"No, the number I am thinking of is higher than {number}");
                    guesses++;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"No, the number I am thinking of is lower than {number}");
                    guesses++;
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Oops no chances left!");


            

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
