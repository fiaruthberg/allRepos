using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandor4__Merge_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.Add("a");
            list1.Add("b");
            list1.Add("c");

            int n1 = list1.Count();


            List<string> list2 = new List<string>();
            list2.Add("1");
            list2.Add("2");
            list2.Add("3");

            int n2 = list2.Count();

            

            //var result = list1.Zip(list2, (f, s) => new String[] { a, b }).SelectMany(x => x);

           // Console.WriteLine(result);
        }

    }
}
