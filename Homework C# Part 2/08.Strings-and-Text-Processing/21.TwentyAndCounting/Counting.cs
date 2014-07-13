using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.TwentyAndCounting
{
    class Counting
    {
        static void Main(string[] args)
        {
            string testStr = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";
            string[] chars = { " ", ".", ",", "!", "..." };

            for (int i = 0; i < chars.Length; i++)
            {
                testStr = testStr.Replace(chars[i], string.Empty);
            }

            int counter = 1;
            for (int i = 0; i < testStr.Length-1; i++)
            {
                if (testStr[i]==testStr[i + 1])
                {
                    counter++;
                }
                else if (testStr[i] != testStr[i + 1] && counter != 1)
                {
                    Console.Write("({0} = {1})",testStr[i],counter);
                    counter = 1;
                }
                else Console.Write(testStr[i]);

            }
        }
    }
}// Not finished.

//Write a program that reads a string from the console and prints all different letters in 
//the string along with information how many times each letter is found. 