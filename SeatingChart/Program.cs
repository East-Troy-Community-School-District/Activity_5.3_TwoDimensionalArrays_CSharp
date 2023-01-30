/*
 * Seating Chart
 * 1/29/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and observe the output. In addition,
 * read the code so you understand how it currently works.
 * Modify the program by adding yourself and your classmates
 * to the seating chart in the correct positions. Please
 * reference the whiteboard to complete this program.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatingChart
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] seatingChart = new string[6, 4];
            PopulateSeatingChart(seatingChart);
            
            seatingChart[0, 2] = "Mr. P";
            // Add your code here!


            Console.WriteLine("\t\t\tFRONT");
            PrintArray(seatingChart);
            Console.WriteLine("\t\t\tBack");
        }

        /*
         * Please don't worry about this code yet.
         * We will discuss traversing 2D arrays tomorrow! 
         * I just don't want to display the values manually.
         */
        public static void PrintArray<T>(T[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1) - 1; j++)
                {
                    Console.Write("{0, 12}, ", a[i, j]);
                }
                Console.WriteLine("{0, 12}", a[i, a.GetLength(1) - 1]);
            }
        }

        public static void PopulateSeatingChart(string[,] chart)
        {
            for (int i = 0; i < chart.GetLength(0); i++)
            {
                for (int j = 0; j < chart.GetLength(1); j++)
                {
                    chart[i, j] = "empty";
                }
            }
        }
    }
}
