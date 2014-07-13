using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.ConsecutiveSeries
{
    class ConsecutiveSeries
    {
        static void Main(string[] args)
        {
            string testStr = "aaaaabbbbbcdddeeeedssaa";

            string newStr=testStr;
            
            for (int i = 0; i < testStr.Length-1; i++)
            {
                if (testStr[i].Equals(testStr[i + 1])) 
                {
                    newStr = newStr.Remove(testStr[i + 1]);
                }
            }

            Console.WriteLine(newStr);
        }
    }
}// Not finished.

//Write a program that reads a string from the console and replaces all series of consecutive
//identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".