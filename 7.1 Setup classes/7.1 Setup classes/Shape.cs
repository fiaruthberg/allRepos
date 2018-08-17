using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Setup_classes
{


    abstract class Shape
    {
        public double height { get; set; }
        public double width { get; set; }
        public double area { get; set; }
        public double volume { get; set; }
        abstract public double CalculateArea();

    }
}
