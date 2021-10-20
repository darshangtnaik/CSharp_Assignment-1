using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Class15
    {
        public static void Main()
        {
            string Word;
            int length = 0;
            Console.WriteLine("Enter the word");
            Word = Console.ReadLine();

            length = Word.Length - 1;

            while (length >= 0)
            {
                Console.Write("{0}", Word[length]);
                length--;
            }


        }
    }
}
