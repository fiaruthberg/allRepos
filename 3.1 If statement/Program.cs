using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_If_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("When did you go to bed yesterday? ");
            int toSleep = int.Parse(Console.ReadLine());

            Console.Write("When did you wake up? ");
            int wokeUp = int.Parse(Console.ReadLine());
            
            Console.WriteLine();

            if (toSleep < wokeUp)
            {
                int hoursOfSleep = wokeUp - toSleep;
                if (hoursOfSleep < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You've only slept {hoursOfSleep} hours. Go back to bed!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You have slept well. ({hoursOfSleep} hours)");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } else
            {
                int hoursOfSleep = 24 - toSleep + wokeUp;
                if (hoursOfSleep < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You've only slept {hoursOfSleep} hours. Go back to bed!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You have slept well. ({hoursOfSleep} hours)");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.WriteLine();


        }
    }
}
