using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Class3
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            
            if(N % 2 == 0)
            {
                Console.WriteLine("It is Even no.");

            }
            else
            {
                Console.WriteLine("It is Odd no.");
            }
        }
    }
}
