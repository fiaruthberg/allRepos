using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7._1_Setup_classes
{
    class Circle : Shape
    {
        public double radius { get; set; }



        public Circle(double x)
        {
            radius = x;
        }

        public override double CalculateArea()
        {
            area = radius * radius * Math.PI;
            area = Math.Round(area, 2);
            return area;
        }
    }
}
