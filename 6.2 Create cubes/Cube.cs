using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2_Create_cubes
{
    class Cube
    {        
        private int height;
        private int width;
        private int depth;
        private int volume;

        public Cube(int x, int y, int z)
        {
            height = x;
            width = y;
            depth = z;
        }

        internal double CalculateVolume()
        {
            volume = height * width * depth;

            return volume;
        }

        internal void WriteVolume()
        {
            volume = height * width * depth;
            Console.WriteLine($"The volume of the cube is {volume}");
        }
       
    }
}
