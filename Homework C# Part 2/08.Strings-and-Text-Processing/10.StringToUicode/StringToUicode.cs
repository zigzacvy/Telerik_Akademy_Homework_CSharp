using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.StringToUicode
{
    class StringToUicode
    {
        static void Main(string[] args)
        {
            Console.Write("Enter random word: ");
            string userWord = Console.ReadLine();

            string unicode = "\\u";

            for (int i = 0; i < userWord.Length; i++)
            {
                Console.Write(unicode + "{0:X4}", (int)userWord[i]);
            }
        }
    }
}

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.