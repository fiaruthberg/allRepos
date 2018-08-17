using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Checkpoint02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine();
                string input = GetInputFromUser();
                List<Room> roomList = CreateListOfRooms(input);
                Console.WriteLine();
                LightsOn(roomList);
                LargestRoom(roomList);
                TotalRooms(roomList);
                Console.WriteLine();




            }
        }

        private static void TotalRooms(List<Room> roomList)
        {
            var xxx = roomList;

            WriteInGreen($"Lägenheten består av {xxx.Count()} rum.");
        }

        private static void LargestRoom(List<Room> roomList)
        {
            var xxx = roomList.OrderByDescending(y => y.Size);


            foreach (var info in xxx)
            {

                WriteInGreen($"\nDet största rummet är {info.Name}, på {info.Size}");
                break;
            }
        }

        private static void LightsOn(List<Room> roomList)
        {
            var xxx = roomList.Where(y => y.LightsOnOff.ToUpper() == "ON").OrderBy(y => y.Name);

            if (xxx.Count() <= 0)
            {
                WriteInGreen("Inget rum är tänt");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Ljuset är tänt i ");
                foreach (var info in xxx)
                {
                    Console.Write($"{info.Name} ");

                }
            }
            
        }

        private static void WriteInGreen(string v)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(v);
            Console.ResetColor();
        }

        private static List<Room> CreateListOfRooms(string input)
        {
            var allRooms = new List<Room>();

            var splittedLine = input.Split('|');


                foreach (string newLine in splittedLine)
                {
                if (!Regex.IsMatch(newLine, @"^\s*[a-zåäö]{3,15}\s{1,}\d+(m2)\s{1,}(off|on)\s*$", RegexOptions.IgnoreCase))
                {
                      WriteInRed($"Ogiltlig indata");
                        break;
                    
                }
                char separator = ' ';
                    var doubleSplittedLine = newLine.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries);

                   if (doubleSplittedLine?.Length < 2)
                  {
                      continue;
                   }
                
                   
                    var nameOfRoom = doubleSplittedLine[0];
                    var size = doubleSplittedLine[1];
                    var lightsOnOff = doubleSplittedLine[2];

                    var room = new Room();
                    room.Name = nameOfRoom;
                    room.Size = size;
                    room.LightsOnOff = lightsOnOff;

                    allRooms.Add(room);

                }
            return allRooms;


        }

        private static void WriteInRed(string v)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(v);
            Console.ResetColor();
        }


        private static string GetInputFromUser()
        {
            Header("Ange rum i lägenheten:");
            string input = Console.ReadLine();

            return input;
        }

        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(v);
            Console.ResetColor();
        }
    }
}
