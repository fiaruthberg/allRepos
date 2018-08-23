using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class MultipleArguments
    {
        public void Run()
        {

            // Returnera närliggande elementen i listan. Den första parametern avser index för "mittenelementet".

            List<string> result = NearbyElements(3, new List<string> { "a", "b", "c", "d", "e" });
            //  ==> c,d,e
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            List<string> result2 = NearbyElements(0, new List<string> { "a", "b", "c", "d", "e" });
            //  ==> a,b
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            List<string> result3 = NearbyElements(4, new List<string> { "a", "b", "c", "d", "e" });
            //  ==> d,e
            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();



            
            //    Multiplicera alla tal i listan med den första parametern

                List<double> result4 = MultiplyAllBy(100, new List<double> { 12, 3.14, 50, 99 });
            //   ==> 1200, 314, 5000, 9900
            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            
             //   Returnera en ny lista där vissa ord är med stora bokstäver. 
             //   Den andra parmetern är en lista av "bool" som anger vilka som ska vara stora.

                List<string> result5 = SomeToUpper(new List<string> {"what", "does", "the", "fox", "says"}, new List<bool> {true, false, false, true, true});
             //   ==> WHAT, DOES, the, fox, SAYS
             

            foreach (var element in result5)
            {
                Console.WriteLine(element);
            }
        }

        private List<string> SomeToUpper(List<string> list1, List<bool> list2)
        {
            var newList = new List<string>();

            int index = 0;

            foreach (var item in list1)
            {
                if (list2[index] == true)
                {
                    newList.Add(item.ToUpper());
                    index++;
                }
                else if (list2[index] == false)
                {
                    newList.Add(item.ToLower());
                    index++;
                }
            }
            return newList;
        }

        private List<double> MultiplyAllBy(int v, List<double> list)
        {
            var newList = new List<double>();

            foreach (var item in list)
            {
                double item2 = item * v;
                newList.Add(item2);
            }
            return newList;
        }

        private List<string> NearbyElements(int v, List<string> list)
        {
            var nearby = new List<string>();

            if (v > 0)
            {
                string s = list[v - 1];
                nearby.Add(s);
            }

            string t = list[v];
            nearby.Add(t);
            
            if (list.Count > v + 1)
            {
                string u = list[v + 1];
                nearby.Add(u);
            }
            return nearby;
        }
    }
}
