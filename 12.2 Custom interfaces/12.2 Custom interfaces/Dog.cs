using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2_Custom_interfaces
{
    class Dog : IFriendly, IAggressive
    {
        public string Name { get; set; }

        public Dog(string v)
        {
            Name = v;
        }
        public int Bite()
        {
            Console.WriteLine($"The dog {Name} bit you!");

            Random rnd = new Random();

            int number = rnd.Next(1, 4);

            return number;

        }

        public void Greet()
        {
            Console.WriteLine($"The dog {Name} says woof");
        }

        public void ShowTeeth()
        {
            Console.WriteLine($"The dog {Name} shows you his teeth");
        }
        public void ThanksForDinner(string meal)
        {
            Console.WriteLine($"The dog {Name} thank you for the {meal}");
        }
    }
}