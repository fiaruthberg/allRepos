using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ange kommando: ");
            string response = Console.ReadLine();

            string[] stringArray = response.Split('-').ToArray();

            foreach (string s in stringArray)
                if (s.StartsWith("A"))
                {
                    string clean = Regex.Replace(s, "[0-9]", "");
                    int numbers = Int32.Parse(clean);


                    for (int i = 0; i < numbers; i++)
                    {
                        Console.WriteLine(new String('*', i));
                    }

                }
                else
                {
                    string clean = Regex.Replace(s, "[0-9]", "");
                    int numbers = Int32.Parse(clean);

                    for (int i = numbers; i > 0; i--)
                    {
                        Console.WriteLine(new String('*', i));
                    }

                }



        }



    }
}
