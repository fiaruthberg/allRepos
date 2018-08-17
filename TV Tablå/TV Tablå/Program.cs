using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_Tablå
{

    class Program
    {


        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("tv-data.txt");

            var allShows = new List<Show>();

            foreach (var line in allLines)
            {
                var splittedLine = line.Split('*');
                var channel = splittedLine[0];
                var time = splittedLine[1];
                var title = splittedLine[2];

                var show = new Show();
                show.Title = title;
                show.Channel = channel;
                show.StartAt = TimeSpan.Parse(time);

                allShows.Add(show);
            }

            Header("alla titlar");

            foreach (var show in allShows)
            {
                Console.WriteLine(show.Title);
            }

            Console.WriteLine();

            Header("alla kanaler");

            foreach (var show in allShows)
            {
                Console.WriteLine(show.Channel);
            }

            Header("alla titlar");

            var laterThan21 = new List<Show>();

            foreach (var show in allShows)
            {
                if (show.StartAt.Hours >= 21)
                {
                    laterThan21.Add(show);
                }
            }

            var x = allShows.Where(y => y.StartAt.Hours >= 21);

            foreach (var show in x)
            {
                WriteInfoAboutShow(show);
            }

            // Annat sätt att sortera
            // allShows.Sort((a,b) => string.CompareOrdinal(a.Title, b.Title));

            Console.WriteLine();

            Header("program från svt1 i kronologisk ordning");

            var xxx = allShows.Where(y => y.Channel == "SVT1").OrderBy(y => y.StartAt);
            foreach (var show in xxx)
            {
                WriteInfoAboutShow(show);
            }


            Console.WriteLine();

        }

        private static void Header(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{s.ToUpper()}\n");
            Console.ResetColor();
        }

        private static void WriteInfoAboutShow(Show show)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{show.Channel.PadRight(4)} {show.StartAt} {show.Title}");
        }
    }
}
