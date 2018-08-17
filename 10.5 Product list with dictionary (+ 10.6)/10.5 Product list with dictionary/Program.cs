using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10._5_Product_list_with_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var productDic = new Dictionary<int, string>();

            while (true)
            {
                string productString = GetUserInput();

                if (string.IsNullOrEmpty(productString))
                {
                    break;
                }

                Match match = Regex.Match(productString, @"^([0-9]*),([a-zåäö ]*)$", RegexOptions.IgnoreCase);
                if (!match.Success)
                {
                    WriteInRed("Invalid input");
                    continue;
                }

                string name = CreateProductName(productString);

                
                string[] s = Regex.Split(productString, @"\D+");
                foreach (string value in s)
                {
                    int numbers = int.Parse(value);
                    if (productDic.ContainsKey(numbers))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"The product list already contain the id {value}");
                        Console.ResetColor();
                        break;
                    }
                    productDic.Add(numbers, name);
                    break;
                }
            }
            PrintDictionary(productDic);
            Console.WriteLine();
        }

        private static string CreateProductName(string productString)
        {
            Console.ForegroundColor = ConsoleColor.White;
            string name = productString.Substring(productString.IndexOf(",") + 1);
            return name;
        }

        private static string GetUserInput()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter product id and name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string productString = Console.ReadLine();

            return productString;
        }

        private static void PrintDictionary(Dictionary<int, string> productDic)
        {
            foreach (KeyValuePair<int, string> KV in productDic)
            {
                Console.ResetColor();
                Console.WriteLine($"Product id={KV.Key} and name={KV.Value}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private static void WriteInRed(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
