using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Class4
    {
        public static void Main()
        {

            int[] numbers = new int[6];
            int EvenCount = 0;
            int OddCount = 0;

            for(int i =0; i<5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i<5; i++)
            {
                if(numbers[i]%2 == 0)
                {
                    EvenCount++;
                }
                else
                {
                    OddCount++;
                }
            }
            Console.WriteLine("EvenCount={0} OddCount={1}", EvenCount, OddCount);
        }
    }
}
