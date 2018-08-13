using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Creating_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            string[] peopleArray;

            string response = GetInfoFromUser();
            peopleArray = CreateArrayOfPeople(response);
            CleanUpArray(peopleArray);

            PeopleArrayIsValid(string[] peopleArray);


            RespondToUder(peopleArray);
            Console.WriteLine();

        }

        

        private static string GetInfoFromUser()
        {
            Console.Write("Enter names separated by comma (e.g Maria,Peter,Lisa): ");
            string anwser = Console.ReadLine();
            Console.WriteLine();

            return anwser;
        }

        private static string[] CreateArrayOfPeople(string response)
        {
            string[] list = response.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            return list;
        }

        private static void CleanUpArray(string[] peopleArray)
        {
            for (var i = 0; i < peopleArray.Length; i++)
            {
                peopleArray[i] = peopleArray[i].Trim();
            }
        }
        private static bool PeopleArrayIsValid(string[] peopleArray)
        {
            if (peopleArray.Length == 0)
            {
                ErrorMessage("The list doesn't contain any names");

                return false;
            }
            foreach (string person in peopleArray)
            {
                if (person.Length <= 1 || person.Length >= 10)
                {
                    ErrorMessage("A person can only have 2 to 9 letters");

                    return false;
                }
            } return true;
        } 

        private static void RespondToUder(string[] peopleArray)
        {
            foreach (string person in peopleArray)
            {
                WriteGreen($"***SUPER-{person.ToUpper()}***");
            }
        }
        private static void ErrorMessage(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void WriteGreen(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
