using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Class2
    {
        public static void Main()
        {
            int n1, n2;
            Console.WriteLine("Enter the two No.");
            n1 =int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            for(int i=n1;i<n2;i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
