using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_Dividing_chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The chocolate contains 24 pieces");
                Console.Write("How many want to share? ");

                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    decimal shares = decimal.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($"Everyone get {24 / shares} pieces");
                    Console.WriteLine();
                    break;
                }
                catch (DivideByZeroException)
                {
                    WriteInRed("Zero people can't divide a chocolate");
                }
                catch (FormatException)
                {
                    WriteInRed("Wrong format.");
                }
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
