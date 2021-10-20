using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Class11
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the three numbers");
            int X= int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int Z= int.Parse(Console.ReadLine());

            if (X > Y)
            {
                if (X > Z)
                {
                    Console.WriteLine("{0} is grater", X);

                }
                else
                {
                    Console.WriteLine("{0} is grater", Z);
                }
            }
            if (X < Y)
            {
                if (Y > Z)
                {
                    Console.WriteLine("{0} is grater", Y);
                }
                else
                {
                    Console.WriteLine("{0} is grater", Z);
                }
            }

        }
    }
}
