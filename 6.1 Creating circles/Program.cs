using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_Creating_circles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Circle bob = new Circle("Bob", 8);
            Circle lisa = new Circle("Lisa", 30);
            Circle ali = new Circle("Ali", 5);
            Circle unknown = new Circle(5);


            bob.SayHello();
            lisa.SayHello();
            ali.SayHello();
            unknown.SayHello();

            Console.WriteLine();

            bob.WriteArea();
            lisa.WriteArea();
            ali.WriteArea();
            unknown.WriteArea();

            Console.WriteLine();
        }
    }
}
