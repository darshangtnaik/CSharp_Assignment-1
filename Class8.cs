using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Class8
    {
        public static void Main()
        {
            int n1 = 0, n2 = 1, n3;
            int Number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 2; i < Number; ++i)
            {
                n3 = n2 + n1;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
