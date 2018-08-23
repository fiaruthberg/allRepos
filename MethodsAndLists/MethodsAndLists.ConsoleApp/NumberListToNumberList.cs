using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToNumberList
    {
        public void Run()
        {
            // Addera 100 till varje siffra i listan

            List<int> result = Add100ToEachNumber(new List<int> { 5, 15, 23, 200 });

            //==> 105, 115, 123, 300
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            // Filtrera ut de tal som är högre än 1000

            List<int> result2 = GetNumbersHigherThan1000(new List<int> { 1005, 6, 77, 200000, 666 });

            // ==> 1005, 200000

            foreach (var number in result2)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            // Returnera de tal som är delbara med 5

            List<int> result3 = GetNumbersDividableByFive(new List<int> { 20, 5, 6, 7, 10 });

            //  ==> 20, 5, 10

            foreach (var number in result3)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            // Dela alla tal i listan med 100

            List<int> result4 = DivideEachNumberBy100(new List<int> { 300, 200, -500, 1000 });

            // ==> 3, 2, -5, 10

            foreach (var number in result4)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            // Negera alla tal i listan

            List<int> result5 = NegateEachNumber(new List<int> { 10, 20, -30, 40 });

            //  ==> -10, -20, 30, -40
            foreach (var number in result5)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();


            // Addera 50 till de tre första elementen i listan

            List<int> result6 = Add50ToFirstThreeElements(new List<int> { 6, 16, 23, 200, 300 });

            //  ==> 56, 66, 73, 200, 300
            foreach (var number in result6)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            List<int> result7 = Add50ToFirstThreeElements(new List<int> { 6, 16 });
            //   ==> 56, 66
            foreach (var number in result7)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();


            // Lägg till 70 till varannat element i listan

            // List<int> result8 = Add70ToEverySecondElement(new List<int> { 1000, 2000, 3000, 4000, 5000 });
            //  ==> 1000, 2070, 3000, 4070, 5000

           // foreach (var number in result8)
           // {
           //     Console.WriteLine(number);
           // }
           //
           // Console.WriteLine();

            
               // Experimentera med att kombinera metoder, t.ex såhär:

                List<int> result9 = DivideEachNumberBy100(NegateEachNumber(new List<int> { 300, 200, -500, 1000 }));
             


            Console.WriteLine("RESULTAT:");
            foreach (var item in result9)
            {
                Console.WriteLine(item);
            }

        }

      //  private List<int> Add70ToEverySecondElement(List<int> list)
      //  {
      //      var newList = new List<int>();
      //      int counter = list.Count();
      //
      //      foreach (var number in list)
      //      {
      //          if (counter % 2 == 0)
      //          var newNumber = number + 70;
      //          newList.Add(newNumber);
      //      }
      //      return newList;
      //  }

        private List<int> Add50ToFirstThreeElements(List<int> list)
        {
            var newList = new List<int>();

            int counter = 0;

            foreach (var number in list)
            {
                if (counter < 3)
                {
                    var newNumber = number + 50;
                    newList.Add(newNumber);
                    counter++;
                }
                else
                {
                    newList.Add(number);
                }
            }
            return newList;
        }

        private List<int> NegateEachNumber(List<int> list)
        {
            var newList = new List<int>();

            foreach (var number in list)
            {
                if (number > 0)
                {
                    var newNumber = number * -1;
                    newList.Add(newNumber);
                }
                else
                {
                    newList.Add(number);
                }
            }
            return newList;
        }

        private List<int> DivideEachNumberBy100(List<int> list)
        {
            var newList = new List<int>();

            foreach (var number in list)
            {
                var newNumber = number / 100;
                newList.Add(newNumber);
            }
            return newList;
        }

        private List<int> GetNumbersDividableByFive(List<int> list)
        {
            var newList = new List<int>();

            foreach (var number in list)
            {
                if (number % 5 == 0)
                {
                    newList.Add(number);
                }
            }
            return newList;
        }

        private List<int> GetNumbersHigherThan1000(List<int> list)
        {
            var newList = new List<int>();

            foreach (var number in list)
            {
                if (number > 1000)
                {
                    newList.Add(number);
                }
            }
            return newList;
        }

        private List<int> Add100ToEachNumber(List<int> list)
        {
            var newList = new List<int>();

            foreach (var number in list)
            {
                int plusHundred = number + 100;
                newList.Add(plusHundred);
            }
            return newList;
        }
    }
}