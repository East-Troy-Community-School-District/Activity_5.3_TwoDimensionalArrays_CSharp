/*
 * Print Each Letter
 * 1/29/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program a few times and observe the output.
 * In addition, read over the code. How is traversing
 * a string similar to traversing arrays?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintEachLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            Console.Write("Enter a word >> ");
            word = Console.ReadLine();

            for(int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }
        }
    }
}
