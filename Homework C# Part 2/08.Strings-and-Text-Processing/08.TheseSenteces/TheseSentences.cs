using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TheseSenteces
{
    class TheseSentences
    {
        static void Main(string[] args)
        {
            string[] testString = @"We are living in a yellow submarine. We don't have anything else.
Inside the submarine is very tight. So we are drinking all the day.
We will move out of it in 5 days.".Split('.');
            string seatchWord = "in";
           
            for (int i = 0; i < testString.Length; i++)
            {
                string[] sentence = testString[i].Split(' ');
                for (int j = 0; j < sentence.Length; j++)
                {
                    if (sentence[j] == seatchWord) Console.Write(testString[i]);
                }
            }

            Console.WriteLine();
        }
    }
}

//Write a program that extracts from a given text all sentences containing given word.
