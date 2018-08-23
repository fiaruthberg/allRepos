using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2_Custom_interfaces
{
    class Cat : IFriendly
    {
        public string Name { get; set; }

        public Cat(string v)
        {
            Name = v;
        }
        public void Greet()
        {
            Console.WriteLine($"The cat {Name} says miao");

        }


        public void ThanksForDinner(string meal)
        {
            Console.WriteLine($"The cat {Name} thank you for the {meal}");

        }
    }
}
