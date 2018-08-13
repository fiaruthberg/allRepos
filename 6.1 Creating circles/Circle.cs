using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_Creating_circles
{
    class Circle
    {
        private string name;
        private double radius;
        private double area;
        private double areaTwoDec;

        public Circle(string x, int y)
        {
            name = x;
            radius = y;
        }
        public Circle(int y)
        {
            name = "Unknown";
            radius = y;
        }
        internal void SayHello()
        {
            Console.WriteLine($"My name is {name}. I have a radius of {radius} and an area of {areaTwoDec}.");
        }
        internal void WriteArea()
        {
            area = Math.PI * (radius * radius);
            areaTwoDec = Math.Round(area, 2);

            Console.WriteLine($"My name is {name}. I have a radius of {radius} and an area of {areaTwoDec}.");
        }
    }
}
