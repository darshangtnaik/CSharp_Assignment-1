using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Class13
    {
        public static void Main(string[] args)
        {
            int Total_Marks = 0, Avg_Marks, Min_Marks, Max_Marks;
            int[] Marks = new int[10];
            Console.WriteLine("Enter the  10 students Marks");
            for (int i = 0; i < 10; i++)
            {
                Marks[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < 10; i++)
            {
                Total_Marks = Total_Marks + Marks[i];

            }

            Avg_Marks = Total_Marks / 10;
            Min_Marks = Marks[0];
            Max_Marks = Marks[0];

            for (int i = 1; i < 10; i++)
            {
                if (Min_Marks > Marks[i])
                {
                    Min_Marks = Marks[i];
                }

            }
            for (int i = 1; i < 10; i++)
            {
                if (Max_Marks < Marks[i])
                {
                    Max_Marks = Marks[i];
                }

            }
            //for (int i = 0; i < 10; i++)
            Array.Sort(Marks);

            Console.WriteLine("Total Marks={0}", Total_Marks);
            Console.WriteLine("Average Marks={0}", Avg_Marks);
            Console.WriteLine("Minimum Marks={0}", Min_Marks);
            Console.WriteLine("Maximum Marks={0}", Max_Marks);

            for (int i = 0; i < 10; i++)
            {
                Console.Write(Marks[i]+" ");
            }

            Array.Reverse(Marks);
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(Marks[i] + " ");
            }




        }
    }
}
