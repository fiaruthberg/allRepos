using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandor4___Hello_in_frame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new[] { "Hello", "World", "in", "a", "frame"};
            int length = 0;

            foreach (var item in words)
            {
                if (length < item.Length)
                {
                    length = item.Length;
                }
            }
            String tabs = new string('*', length + 4);

            Console.WriteLine(tabs);

            foreach (var item in words)
            {
                Console.WriteLine($"* {item.PadRight(length, ' ')} *");
            }
            Console.WriteLine(tabs);


            Console.ReadKey();
        }
    }
}
