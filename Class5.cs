using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Class5
    {
        public static void Main()
        {
            
            Console.WriteLine("Enter the temperature in Fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine(celsius);

        }
    }
}
