using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Böcker_3
{
    class ElectronicBook : Book
    {
        public ElectronicBook(string isbn, string name) : base(isbn, name)
        {
        }
        internal void SendBookTo(string emailAdress)
        {
            Console.WriteLine($"Anrop: ");
            Console.WriteLine();
            Console.Write($"    Send book to {emailAdress}");
        }
    }
}
