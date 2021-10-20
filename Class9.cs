using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Class9
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Number");

            int Num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine(Num * i);
            }

        }
    }
}
