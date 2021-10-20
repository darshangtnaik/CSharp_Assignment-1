using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Class12
    {
        public static void Main(string[] args)
        {
            int[] Array = new int[5];
            Console.WriteLine("Enter the  5 numbers");
            for(int i = 0; i < 5; i++)
            {
                Array[i] = int.Parse(Console.ReadLine());

            }

            int Min = Array[0];
            for(int i = 1; i < 5; i++)
            {
                if (Min > Array[i])
                {
                    Min = Array[i];
                }
            }
            Console.WriteLine("Smallest of these numbers is {0}",Min);
        }
    }
}
