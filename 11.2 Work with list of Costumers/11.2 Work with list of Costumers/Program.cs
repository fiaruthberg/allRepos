using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2_Work_with_list_of_Costumers
{
    class Program
    {


        static void Main(string[] args)
        {
            var parser = new Parser();
            List<Costumer> list = parser.CreateListOfCostumers(@"C:\Project\AcceleratedLearning\C#\PURE\11.2 Work with list of Costumers\11.2 Work with list of Costumers\PersonShort.csv");
            Header("Sorted list by age:");
            PrintListByAge(list);
            Header("Sorted list by first name:");
            PrintListByFirstName(list);
            Header("Men older then 35:");
            OlderMenThan35(list);
            Header("Manipulated:");
            Manipulated(list);


        }

        private static void Manipulated(List<Costumer> list)
        {
            var xxx = list.Where(y => y.Age > 35).OrderBy(y => y.FirstName);

            foreach (var info in xxx)
            {
                Console.WriteLine($"{info.FirstName.ToUpper().PadRight(20)}{(info.Age+1000).ToString().PadRight(20)}{info.Gender}");
            }

        }

        private static void OlderMenThan35(List<Costumer> list)
        {
            var xxx = list.Where(y => y.Age > 35).OrderBy(y => y.Age);

            foreach (var info in xxx)
            {
                WriteInfoAboutShow(info);
            }

        }

        private static void PrintListByAge(List<Costumer> list)
        {
            var xxx = list.OrderBy(y => y.Age);

            foreach (var info in xxx)
            {
                WriteInfoAboutShow(info);
            }

        }

        private static void PrintListByFirstName(List<Costumer> list)
        {
            var xxx = list.OrderBy(y => y.FirstName);

            foreach (var info in xxx)
            {
                WriteInfoAboutShow(info);
            }

        }

        private static void WriteInfoAboutShow(Costumer info)
        {
            Console.WriteLine($"{info.FirstName.PadRight(20)}{info.Age.ToString().PadRight(20)}{info.Gender}");
        }
        private static void Header(string s)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n{s}");
            Console.ResetColor();
        }
    }
}
