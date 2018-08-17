using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._4_Manipulate_a_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();

            while(true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter a name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string nameString = Console.ReadLine().ToLower().Trim();
                Console.ForegroundColor = ConsoleColor.White;

                if (nameString == "quit")
                {
                    nameList.Sort();
                    int length = nameList.Count;
                    nameList.RemoveAt(length - 1);
                    nameList.RemoveAt(0);

                    foreach (string names in nameList)
                    {
                        Console.WriteLine(names);
                    }
                    break;
                }
                else
                {
                    string upperCase = UpperCaseName(nameString);
                    nameList.Add($"Name: {upperCase}");
                    continue;
                }

            }                    

        }

        private static string UpperCaseName(string nameString)
        {
            string upper = nameString.First().ToString().ToUpper() + nameString.Substring(1);
            return upper;
        }
    }
}
