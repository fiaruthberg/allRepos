using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_String_creation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter fruit 1: ");
            string fruit1 = Console.ReadLine();

            Console.Write("Enter fruit 2: ");
            string fruit2 = Console.ReadLine();

            Console.Write("Enter fruit 3: ");
            string fruit3 = Console.ReadLine();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("You entered three fruits: " + fruit1 + ", " + fruit2 + ", " + fruit3 + "!");
            Console.WriteLine("You entered three fruits: {0}, {1}, {2}!", fruit1, fruit2, fruit3);
            Console.WriteLine($"You entered three fruits: {fruit1}, {fruit2}, {fruit3}!");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        }
    }
}
