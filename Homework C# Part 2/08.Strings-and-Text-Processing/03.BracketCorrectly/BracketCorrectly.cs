using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BracketCorrectly
{
    class BracketCorrectly
    {
        static void Main(string[] args)
        {
            string testExpressionCorrect = "(((a+b)*c)+((a+b)/2))";
            string testExpressionIncorrect = "()(a+b(*c)+))a+b(/2()";
            int bracketCounter = 0;

            for (int i = 0; i < testExpressionIncorrect.Length; i++)
            {
                if (testExpressionIncorrect[i] == ')')
                {
                    bracketCounter--;
                    if (bracketCounter < 0)
                    {
                        Console.Write("The brackets are put incorrectly."); break;
                    }
                }
                else if (testExpressionIncorrect[i] == '(') bracketCounter++;
            }

            if (bracketCounter > 0) Console.Write("The brackets are put incorrectly.");
            else if (bracketCounter==0) Console.WriteLine("The brackets are put correctly.");
            Console.WriteLine();
        }
    }
}

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).