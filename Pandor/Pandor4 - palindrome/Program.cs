using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandor4___palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = AskForString();
            if (IsPalindrome(word))
            {
                Console.WriteLine($"Yep! {word} is a palindrome");
            }
            Console.WriteLine($"Sorry! {word} is not a palindrome");

            Console.ReadKey();
        }
        public static bool IsPalindrome(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            string backwards = new string(array);

            return s == backwards;
        }

        private static string AskForString()
        {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();

            return word;
        }
    }
}
