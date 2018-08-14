using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Setup_classes
{
    class Rectangle : Shape
    {
        public double radius { get; set; }
        
        public Rectangle(double x, double y)
        {
            height = x;
            width = y;
        }
    }
}
