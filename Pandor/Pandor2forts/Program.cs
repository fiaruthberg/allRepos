using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandor2forts
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = AskForNumber();
            char doWhat = SumOrProduct();
            ComputNumber(number, doWhat);
        }

        private static void ComputNumber(int number, char doWhat)
        {
            if (doWhat == '*')
            {
                int computed = number * 1;
                Console.WriteLine(computed);
            }
            else
            {
                int computed = number + 1;
                Console.WriteLine(computed);
            }
        }

        private static char SumOrProduct()
        {
            Console.WriteLine("Would you like to see the sum or product of 1 and your number? +/*: ");
            char doWhat = char.Parse(Console.ReadLine());

            return doWhat;
        }

        private static int AskForNumber()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }
    }
}
