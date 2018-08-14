using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Böcker_2
{
    class ElectronicBook : Book
    {
        internal void SendBookTo(string emailAdress)
        {
            Console.WriteLine($"Anrop: ");
            Console.WriteLine();
            Console.Write($"    Send book to {emailAdress}");
        }
    }
}
