using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandor2sista
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {

                    if (i == 0)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        if (j == 0)
                        {
                            Console.Write(i);
                        }
                        else
                        {
                            Console.Write(i * j);
                        }
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
