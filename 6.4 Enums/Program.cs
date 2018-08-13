using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            var person1 = new Person
            {
                FirstName = "Lisa",
                Gender = Gender.Female,
                FavoriteSport = Sport.Tennis
            };
            person1.WriteInfo();
            Console.WriteLine(person1.LikeRugby());

            Console.WriteLine();

            WriteAllSports();
            Console.WriteLine();
            CheckSportInEnum();
            Console.WriteLine();


        }

        private static void CheckSportInEnum()
        {
            Console.Write($"Enter a sport: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string sport = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            if (Enum.TryParse(sport, true, out Sport myenum))
            {
                Console.WriteLine($"Oh, I know {myenum}!");
            }
            else
            {
                Console.WriteLine($"Sorry, I don't know {sport}!");
            }
        }
        private static void WriteAllSports()
        {
            Console.WriteLine("Here is a list of all Sport enums:");

            foreach (string sport in Enum.GetNames(typeof(Sport)))
            {
                Console.WriteLine($"* {sport}");
            }
        }       
    }
}
