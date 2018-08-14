using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Böcker_1
{
    class Book
    {
        private string author { get; set; }
        private string isbn { get; set; }
        private int nrOfPages { get; set; }


        internal void SetIsbn(string newIsbn)
        {
            isbn = newIsbn;

        }

        internal object GetAuthor()
        {
            return author;
        }

        internal object GetNrOfPages()
        {
            if (nrOfPages > 1000)
            {
                nrOfPages = 300;
            }
            return nrOfPages;
        }

        internal object Size()
        {
            string size;

            if (nrOfPages < 100)
            {
                size = "Tunn";
                return size;
            }
            else if (nrOfPages > 300)
            {
                size = "Tjock";
                return size;
            }
            else
            {
                size = "Normal";
                return size;
            }
        }

        internal object WeightInGram()
        {
            double grams = nrOfPages * 0.8;
            return grams;
        }

        internal object GetIsbn()
        {
            return isbn;
        }

        internal void SetNrOfPages(int newNrOfPages)
        {
            nrOfPages = newNrOfPages;
        }

        internal void SetAuthor(string newAuthor)
        {
            author = newAuthor;
        }



    }
}
