using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Class17
    {
        public static void Main()
        {
            string Word;
            string Word_rev = string.Empty;
            int length = 0;
            Console.WriteLine("Enter the word");
            Word = Console.ReadLine();

            length = Word.Length - 1;

            for (int i =Word.Length - 1; i >= 0; i--)
            {
                Word_rev += Word[i].ToString();
            }
            if(Word_rev == Word)
            {
                Console.WriteLine("It is a Palindrome");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome");
            }


        }
    }
}
