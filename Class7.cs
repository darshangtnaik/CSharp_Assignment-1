using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Class7
    {
        public static void Main()
        {
            int fact = 1;
            Console.WriteLine("Enter the Number");

            int Num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= Num; i++)
            {
                fact = fact * i;

            }

            Console.WriteLine(fact);
        }
    }
}
