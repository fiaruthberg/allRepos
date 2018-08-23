using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandor4___Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci(100);

            Console.ReadLine();
        }
        public static void Fibonacci (int x)

        {
            decimal a = 0, b = 1, c = 0;

            Console.WriteLine($"{a}");
            Console.WriteLine($"{b}");

            for (int i = 1; i < x; i++)
            {
                c = a + b;

                Console.WriteLine($"{c}");

                a = b;
                b = c;
            }
        }
    }
}
