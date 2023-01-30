/*
 * Rectangular Array
 * 1/29/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and observe the output. After looking over
 * the code, answer the following questions...
 * 1. What is a rectangular 2D array?
 * 2. When declaring a 2D array, do you give the number of rows
 *    or the number of columns first?
 * Modify the program by declaring and creating a 2D array that
 * contains 3 rows and 7 columns. Have your 2D array store
 * double values. Finally, print your 2D array using the provided
 * PrintArray() method to check your work.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] wideArray = new int[10, 2];
            Console.WriteLine("wideArray:");
            PrintArray(wideArray);
            Console.WriteLine();

            int[,] tallArray = new int[2, 10];
            Console.WriteLine("tallArray:");
            PrintArray(tallArray);
            Console.WriteLine();

            // Write your code here!

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
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0, -8}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
