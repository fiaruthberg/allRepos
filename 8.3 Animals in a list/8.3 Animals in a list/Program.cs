using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8._3_Animals_in_a_list
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animalArray;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter a list of animals: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string animalsString = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                try
                {
                    ParseAnimals(animalsString);

                }
                catch (ArgumentException ex)
                {
                    WriteInRed(ex.Message);
                    continue;
                }
                animalArray = ParseAnimals(animalsString);
                Console.WriteLine($"There are {animalArray.Length} animals in the list");
                break;
            }
            Console.WriteLine();


        }

        private static string[] ParseAnimals(string animalsString)
        {

            string[] list = animalsString.Split(new[] { ',' });

            for (var i = 0; i < list.Length; i++)
            {
                list[i] = list[i].Trim();
            }

            if (string.IsNullOrEmpty(animalsString))
            {
                throw new ArgumentException("Animal string doesn't contain any letters");
            }
            foreach (string animals in list)
            {
                if (string.IsNullOrEmpty(animals))
                {
                    throw new ArgumentException("One of the animals doesn't contain any letters");
                }
                if (animals.Length > 20)
                {
                    throw new ArgumentException($"This animal '{animals}' has too many letters");
                }

                if (!Regex.IsMatch(animals, @"^[a-zA-ZåäöÅÄÖ]*$"))
                {
                    throw new ArgumentException($"Animal: {animals} contains invalid letters");
                }

            }
            return list;

        }

        private static void WriteInRed(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
