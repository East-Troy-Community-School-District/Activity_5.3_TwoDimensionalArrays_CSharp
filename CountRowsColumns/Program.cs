/*
 * Count Rows Columns
 * 1/29/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program a few times and try a variety of
 * row and column amounts. Be prepared to answer the
 * following questions...
 * 1. Given the number of rows and columns, how do you
 *    find the number of elements a 2D array can store?
 * 2. What does the number within the GetLength() method
 *    represent?
 * 3. How might finding the number of rows and columns
 *    be useful in the future?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRowsColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, columns;
            Console.Write("Enter the number of rows for the grid >> ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns for the grid >> ");
            columns = Convert.ToInt32(Console.ReadLine());

            int[,] grid = new int[rows, columns];
            Console.WriteLine("Length: " + grid.Length);
            Console.WriteLine("Rows: " + grid.GetLength(0));
            Console.WriteLine("Columns: " + grid.GetLength(1));
        }
    }
}
