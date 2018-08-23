using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToStringList
    {

        public void Run()
        {
            
               // Lägg till tre stjärnor innan och efter siffran
                
                List<string> result = AddStars(new List<int> { 1003, 20, -130, 2040 });

               // ==>  ***1003***, ***20***, ***-130***, ***2040***

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            
               // Samma men lägg bara till stjärnor runt de som är större än 1000
             
                List<string> result2 = AddStarsToNumbersHigherThan1000(new List<int> { 1003, 20, -130, 2040 });

               // ==>   ***1003***, 20, -130, ***2040***

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            
              //  Negativa tal => "ZIP"
              //  Positiva tal => "ZAP"
              //  Noll         => "BOING"
            
                List<string> result3 = NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(new List<int> { 1003, 20, -130, 0, 2040 });
       
            // =>    ZAP, ZAP, ZIP, BOING, ZAP

            foreach (var item in result3)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            Console.WriteLine();
            
               // Skapa en lista av strängar som meddelar om personen är kort eller lång (över 160cm). Hoppa över orimliga värden

                List<string> result4 = LongOrShort(new List<int> {170, 130, 205, -10, 600, 180});

               // ==>    LÅNG, KORT, LÅNG, LÅNG


            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }
        }

        private List<string> LongOrShort(List<int> list)
        {
            var newList = new List<string>();

            foreach (var number in list)
            {
                if (number >= 160 && number < 210)
                {
                    newList.Add("Long");
                }
                else if (number < 160 && number > 120)
                {
                    newList.Add("Short");
                }
            }
            return newList;
        }

        private List<string> NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(List<int> list)
        {
            var newList = new List<string>();

            foreach (var number in list)
            {
                if (number > 0)
                {
                    newList.Add("Zap");
                }
                else if (number == 0)
                {
                    newList.Add("Boing");
                }
                else
                {
                    newList.Add("Zip");
                }


            }
            return newList;
        }

        private List<string> AddStarsToNumbersHigherThan1000(List<int> list)
        {
            var newList = new List<string>();

            foreach (var number in list)
            {
                if (number > 1000)
                {
                    newList.Add($"***{number}***");
                }
                else
                {
                    newList.Add($"{number}");
                }

            }
            return newList;
        }

        private List<string> AddStars(List<int> list)
        {
            var newList = new List<string>();

            foreach (var number in list)
            {
                    newList.Add($"***{number}***");
                
            }
            return newList;
        }
    }
}