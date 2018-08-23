using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class StringListToBool
    {
        public void Run()
        {
            // Demo: Returerna "true" om längen på alla ord tillsammans är större än 10

            
              //  Returnera "true" om alla ord har fem eller fler tecken
             
                bool result = AllWordsAreFiveLettersOrLonger(new List<string> { "abcdef", "friday", "ooooooooo" });
            // ==> true
            Console.WriteLine(result);

                bool result2 = AllWordsAreFiveLettersOrLonger(new List<string> { "abcdef", "fri", "ooooooooo" });
            // ==> false
            Console.WriteLine(result2);
            

            //Console.WriteLine(result);
        }

        private bool AllWordsAreFiveLettersOrLonger(List<string> list)
        {
            int countWordsLongerThan = 0;
            int countWordsShorterThan = 0;

            foreach (var words in list)
            {
                if (words.Length >= 5)
                {
                    countWordsLongerThan++;
                }
                if (words.Length < 5)
                {
                    countWordsShorterThan++;
                }
            }

            if (countWordsLongerThan > 0 && countWordsShorterThan == 0)
            {
                return true;
            }
           
            else
            {
                return false; ;
            }
        }
    }
}
