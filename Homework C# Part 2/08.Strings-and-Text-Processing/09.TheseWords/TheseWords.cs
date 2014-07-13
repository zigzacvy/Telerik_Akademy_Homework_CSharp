using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.TheseWords
{
    class TheseWords
    {
        static void Main(string[] args)
        {
            string testString = @"Microsoft announced its next generation PHP compiler today.
It is based on .NET Framework 4.0 and is implemented
as a dynamic language in CLR.";
            string[] searchWord = {"PHP","CLR","Microsoft"};

            for (int i = 0; i < searchWord.Length; i++)
            {
                testString = testString.Replace(searchWord[i], new string('*', searchWord[i].Length));
            }

            Console.WriteLine(testString);
        }
    }
}

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks. 