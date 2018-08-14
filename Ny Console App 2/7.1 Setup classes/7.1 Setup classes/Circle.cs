using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Setup_classes
{
    class Circle : Shape
    {
        public double radius { get; set; }
        public double area { get; set; }
        public double volume { get; set; }

        public Circle(double x)
        {
            radius = x;
            
        }
    }
}
