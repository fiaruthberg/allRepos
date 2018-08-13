using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4_Get_accessor
{
    class Program
    {
        static void Main(string[] args)
        {
            var adress1 = new Address
            {
                Street = "Långa gatan",
                StreetNumber = "13B",
                City = "Sundsvall",
                ZipCode = "111 22"
            };
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(adress1.GetFullStreet());
            Console.WriteLine();
            Console.WriteLine(adress1.FullStreet);

        }

        
    }
}
