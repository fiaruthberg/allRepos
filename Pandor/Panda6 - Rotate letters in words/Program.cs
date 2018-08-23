using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panda6___Rotate_letters_in_words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            Console.WriteLine();

            Header("Substring");
            Console.WriteLine(PigLatin(sentence));

            Header("Skip/Take");
            Console.WriteLine(PigLatinSkip(sentence));

            Console.WriteLine("Enter a pig latin sentence: ");
            string pigLatinSentence = Console.ReadLine();
            Console.WriteLine(ReversePigLatin(pigLatinSentence));



        }

        private static string PigLatinSkip(string sentence)
        {
            List<string> wordPlusAy = new List<string>();

            foreach (string word in sentence.Split(' '))
            {
                string firstLetter = word.Take(1);
                string restOfWord = word.Skip(1);

                wordPlusAy.Add($"{restOfWord}{firstLetter}ay");

            }
            return string.Join(" ", wordPlusAy);
        }

        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(v);
            Console.ResetColor();
        }

        static string PigLatin(string sentence)
        {

            List<string> wordPlusAy = new List<string>();

            foreach (string word in sentence.Split(' '))
            {
                string firstLetter = word.Substring(0, 1);
                string restOfWord = word.Substring(1, word.Length - 1);

                wordPlusAy.Add($"{restOfWord}{firstLetter}ay");

            }
            return string.Join(" ", wordPlusAy);
        }
    }
}

