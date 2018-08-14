using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Böcker_3
{
    class Book : Product
    {
        public string Name { get; set; }
        public string Isbn { get; set; }
        public string Author { get; set; }
        public int NrOfPages { get; set; }

        public Book(string x, string y)
        {
            Isbn = x;
            Name = y;
        }



        internal string Size
        {
            get
            {
                if (NrOfPages < 100)
                {
                    return "Tunn";
                }
                else if (NrOfPages > 300)
                {
                    return "Tjock";
                }
                else
                {
                    return "Normal";
                }
            }
        }


        internal object WeightInGram
        {
            get { return NrOfPages * 0.8; }
        }

        




    }
}
