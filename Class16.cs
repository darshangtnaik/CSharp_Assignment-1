using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Class16
    {
        public static void Main()
        {
            string str1, str2;
            Console.WriteLine("Enter the two Strings");
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            if (str1.Equals(str2))
            {
                Console.WriteLine("Two words are same");
            }
            else
            {
                Console.WriteLine("Two words are not same");
            }

        }
    }
}
