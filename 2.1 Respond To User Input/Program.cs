using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Respond_To_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("How old are you? ");
            string age = Console.ReadLine();

            Console.Write("What is your favourite letter? ");
            string letter = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Thank you!");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your name is: {name}");
            Console.WriteLine($"You are {age} years old");
            Console.WriteLine($"Your favourite letter is {letter}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();



        }
    }
}
