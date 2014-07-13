using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.AlphabeticalOrder
{
    class AlphabeticalOrder
    {
        static void Main(string[] args)
        {
            string[] testStr = @"Write a program that reads a list of words,
separated by spaces and prints the list
in an alphabetical order.".Split(' ');
            int len = testStr.Length;

            List<string> words = new List<string>();

            for (int i = 0; i < len; i++)
            {
                words.Add(testStr[i]);
            }

            words.Sort();

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}

//Write a program that reads a list of words, separated by spaces
//and prints the list in an alphabetical order.
