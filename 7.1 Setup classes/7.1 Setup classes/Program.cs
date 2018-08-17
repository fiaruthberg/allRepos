using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Setup_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = AskForListOfShapes();

            PrintAllShapes(shapeList);
            Console.WriteLine();
        }

        private static void PrintAllShapes(List<Shape> shapeList)
        {
            Console.WriteLine();

            foreach (Shape item in shapeList)
            {
                string trimmed = item.ToString().Replace("_7._1_Setup_classes.", "");
                WriteInGray($"\n{trimmed}        {item.CalculateArea()}");
            }

        }

        private static List<Shape> AskForListOfShapes()
        {
            bool oneMore = true;
            List<Shape> allShapes = new List<Shape>();

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Select (T)riangle. (R)ectangle, (C)ircle or (D)one: ");
                Console.ForegroundColor = ConsoleColor.Green;

                string selection = Console.ReadLine().ToLower();

                Console.ForegroundColor = ConsoleColor.White;

                switch (selection)
                {
                    case "t":
                        Triangle triangle = AskForTriangle();

                        allShapes.Add(triangle);

                        break;

                    case "r":
                        Rectangle rectangle = AskForRectangle();

                        allShapes.Add(rectangle);

                        break;

                    case "c":
                        Circle circle = AskForCircle();

                        allShapes.Add(circle);

                        break;

                    case "d":
                        oneMore = false;
                        break;

                }
            } while (oneMore);

            return allShapes;


        }

        private static Rectangle AskForRectangle()
        {
            WriteInWhite($"Enter height of rectangle: ");
            double heoghtOfRectangle = double.Parse(Console.ReadLine());

            WriteInWhite($"Enter width of rectangle: ");
            double widthOfRectangle = double.Parse(Console.ReadLine());

            return new Rectangle(heoghtOfRectangle, widthOfRectangle);

        }

        private static Triangle AskForTriangle()
        {
            WriteInWhite($"Enter base of triangle: ");
            double baseLength = double.Parse(Console.ReadLine());

            WriteInWhite($"Enter height of triangle: ");
            double height = double.Parse(Console.ReadLine());
                        
            return new Triangle(height, baseLength);
        }
        private static Circle AskForCircle()
        {
            WriteInWhite($"Enter radius of circle: ");
            double radius = double.Parse(Console.ReadLine());

            return new Circle(radius);
        }
        private static void WriteInWhite(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.Green;
        }
        private static void WriteInGray(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
