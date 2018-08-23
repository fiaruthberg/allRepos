using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandor4____Rotate_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            numberList.Add(4);
            numberList.Add(5);
            numberList.Add(6);


            List<int> rotated = RotateList(numberList, 2);
            Header("List: ");
            foreach (var number in rotated)
            {
                Console.WriteLine(number);
            }          
        }

        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(v);
            Console.ResetColor();
        }

        private static List<int> RotateList(List<int> numberList, int offset)
        {
            return numberList.Skip(offset).Concat(numberList.Take(offset)).ToList();
        }        
    }
}
