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

            string myString = (number1 > number2) ? "First number is higher" : (number1 == number2) ? "They are equal" : "First number is lower";
           
            Console.WriteLine(myString);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
