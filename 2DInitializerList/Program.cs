/*
 * 2D Initializer List
 * 1/29/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and observe the output. After looking over
 * the code, answer the following questions...
 * 1. How is an initializer list structured for 2D arrays?
 * 2. An the initializer list for a 2D array, what represents
 *    a row?
 * Modify the program by declaring a 2D array and using an
 * initializer list to store the following values in the array...
 * 1.2, 3.4
 * 6.6, 8.8
 * 
 * Finally, print your 2D array using the provided
 * PrintArray() method to check your work.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DInitializerList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] example = { { 2, 4, 5 }, { 6, 8, 9 }, { 3, 1, 7 } };
            Console.WriteLine("example:");
            PrintArray(example);
            Console.WriteLine();

            string[,] anotherExample = { { "00", "01", "02", "03", "04" },
                                      { "10", "11", "12", "13", "14" },
                                      { "20", "21", "22", "23", "24" } };
            Console.WriteLine("anotherExample:");
            PrintArray(anotherExample);
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
