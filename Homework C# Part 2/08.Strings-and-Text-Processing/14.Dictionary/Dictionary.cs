using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            string[] dictionary = @".NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes".Split('\n');

            Console.WriteLine("The dictionary has definitions only for .NET, CLR, namespace.");
            Console.Write("Enter word :");
            string userWord = Console.ReadLine();

            for (int i = 0; i < dictionary.Length; i++)
            {
                string[] definition = dictionary[i].Split(' ');
                if (definition[0] == userWord)
                {
                    Console.WriteLine(dictionary[i]); break;
                }
                      
            }
        }
    }
}

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary. Sample dictionary: