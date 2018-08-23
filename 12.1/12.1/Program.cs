using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rockstarsArray = new string[] { "Jim Morrison", "Ozzy Osborne"};
            List<string> rockstarsList = new List<string> { "Jim Morrison", "Ozzy Osborne" };
            DisplayArrayOfRockStars(rockstarsArray);
            Console.WriteLine();
            DisplayListOfRockstars(rockstarsList);
            Console.WriteLine();
            DisplayRockStars(rockstarsList);
            Console.WriteLine();
            RemoveFirstRockStar(rockstarsList);

        }

        private static void DisplayListOfRockstars(List<string> rockstarsList)
        {
            string ny = "Kalle";
            rockstarsList.Add(ny);

            foreach (var rockstar in rockstarsList)
            {
                Console.WriteLine(rockstar);
            }
        }

        private static void DisplayArrayOfRockStars(string[] rockstarsArray)
        {
            foreach (var rockstar in rockstarsArray)
            {
                Console.WriteLine(rockstar);
            }
        }
        private static void DisplayRockStars (IEnumerable<string> rockstars)
        {
            foreach (var rockstar in rockstars)
            {
                Console.WriteLine(rockstar);
            }
        }
        private static void RemoveFirstRockStar(IEnumerable<string> rockstars)
        {
            string min = rockstars.Min();
            List<string> list = rockstars.Where(val => val != min).ToList();

            foreach (var rockstar in list)
            {
                Console.WriteLine(rockstar);
            }

        }
    }
}
        
    
