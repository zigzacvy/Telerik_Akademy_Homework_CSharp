using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SentenceReverser
{
    class SentenceReverser
    {
        static void Main(string[] args)
        {
            char[] spliters = { ' ', ',', '.', '!' };
            string[] testSentence = "C# is not C++, not PHP and not Delphi!".Split(spliters);

            for (int i = testSentence.Length-1; i >-1 ; i--)
            {
                Console.Write(testSentence[i]+' ');
            }
            Console.WriteLine();
        }
    }
}// Not finished.

//Write a program that reverses the words in given sentence.