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

            string[] nameArray;

            Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");
            string names = Console.ReadLine();

            nameArray = names.Split(',').ToArray();

            Console.WriteLine();

            foreach (string name in nameArray)
            {
                string nameToLower = name.ToLower();
                if (nameToLower == "zelda")
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{name} Andersson");
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
