using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToString
    {

        public void Run()
        {



            // Returnera en text som talar om vilket det första och sista numret är i listan

            string result = ReportFirstAndLastValue(new List<int> { 5, 1000, 2000, 3000, 6 });

            // ==>    Första siffran är 5 och sista siffran är 6




            // Returnera en text som säger om alla nummer är högre än 100 eller inte.

            string result2 = ReportIfAllValuesAreHigherThan100(new List<int> { 200, 105, 150 });
            //  ==>    Alla nummer är högre än 100

            string result3 = ReportIfAllValuesAreHigherThan100(new List<int> { 200, 98, 150 });
            //  ==>    Något nummer är lägre än 100
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine();


            //  Returnera en text hur många negativa tal som finns i listan

            string result4 = ReportNumberOfNegativeValues(new List<int> { 5, 7, -2, 100, -4 });
            //  ==>     Det finns 2 st negativa tal i listan

            Console.WriteLine(result4);

            string result5 = ReportNumberOfNegativeValues(new List<int> { 5, 7, 44, 100, 33 });
            //  ==>     Jippi! Det finns inga negativa tal i listan
            Console.WriteLine(result5);



            //Console.WriteLine("RESULT");
            //Console.WriteLine(result);

        }

        private string ReportNumberOfNegativeValues(List<int> list)
        {
            int countValuesHigherThan = 0;
            int countValuesLowerThan = 0;

            foreach (var value in list)
            {
                if (value >= 0)
                {
                    countValuesHigherThan++;
                }
                if (value < 0)
                {
                    countValuesLowerThan++;
                }
            }

            if (countValuesLowerThan > 0)
            {
                return $"Det finns {countValuesLowerThan} negativa tal i listan";
            }
            if (countValuesLowerThan == 0)
            {
                return $"Jippi! Det finns inga negativa tal i listan";
            }
            else
            {
                return "Inget nummer är högre än 100";
            }
        }

        private string ReportIfAllValuesAreHigherThan100(List<int> list)
        {
            int countValuesHigherThan = 0;
            int countValuesLowerThan = 0;

            foreach (var value in list)
            {
                if (value >= 100)
                {
                    countValuesHigherThan++;
                }
                if (value < 100)
                {
                    countValuesLowerThan++;
                }
            }

            if (countValuesHigherThan > 0 && countValuesLowerThan == 0)
            {
                return "Alla nummer är högre än 100";
            }
            if (countValuesHigherThan > 0 && countValuesLowerThan > 0)
            {
                return "Något nummer är högre än 100";
            }
            else
            {
                return "Inget nummer är högre än 100";
            }


        }

          private string ReportFirstAndLastValue(List<int> list)
          {
            int length = list.Count;

            var firstValue = list[0];
            var lastValue = list[length-1];


       
              return $"Första siffran är {firstValue} och sista siffran är {lastValue}";
          }
    }
}