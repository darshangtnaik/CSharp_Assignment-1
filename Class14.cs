using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Class14
    {
        public static void Main()
        {
            string Word;
            int length = 0;
            Console.WriteLine("Enter the word");
            Word = Console.ReadLine();

            foreach(char chr in Word)
            {
                length++;
            }
            Console.WriteLine("Length is {0}",length);

        }
    }
}
