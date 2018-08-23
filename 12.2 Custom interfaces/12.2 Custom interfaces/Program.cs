using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2_Custom_interfaces
{
    public interface IFriendly
    {
        void Greet();
        void ThanksForDinner(string meal);
    }
    public interface IAggressive
    {
        int Bite();
        void ShowTeeth();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog buddy = new Dog("Buddy");
            Cat musse = new Cat("Musse");

            DoNiceThings(buddy);
            DoMeanThings(buddy);

            DoNiceThings(musse);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void DoNiceThings(IFriendly animal)
        {
            Header("DoNiceThings");
            animal.ThanksForDinner("mouse");
        }
        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(v);
            Console.ResetColor();
        }
        public static void DoMeanThings(IAggressive animal)
        {
            Header("DoMeanThings");
            animal.ShowTeeth();
            switch (animal.Bite())
            {
                case 1:
                    Console.WriteLine("You lost one leg");
                    break;
                case 2:
                    Console.WriteLine("You lost your legs");
                    break;
                case 3:
                    Console.WriteLine("You lost one arm");
                    break;
                case 4:
                    Console.WriteLine("You lost your arms");
                    break;
            }
        }       
    }
}
