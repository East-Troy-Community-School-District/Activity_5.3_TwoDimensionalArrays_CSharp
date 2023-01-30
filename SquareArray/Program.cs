/*
 * Square Array
 * 1/29/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and observe the output. Be prepared to discuss
 * the following questions...
 * 1. How does the syntax for declaring a 2D array differ from 1D
 *    arrays? How is it similar?
 * 2. This program creates 2 square 2D arrays. What is a square 
 *    2D array?
 * Modify the program to create a new 2D square array that is 10
 * by 10 and stores bool values. Using the provided PrintArray()
 * method, display your array to the console.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];
            Console.WriteLine("array:");
            PrintArray(array);
            Console.WriteLine();

            double[,] anotherArray = new double[2, 2];
            Console.WriteLine("anotherArray:");
            PrintArray(anotherArray);
            Console.WriteLine();

            // Add your code here!

        }

        /*
         * Please don't worry about this code yet.
         * We will discuss traversing 2D arrays tomorrow! 
         * I just don't want to display the values manually.
         */
        public static void PrintArray<T>(T[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0, -8}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
