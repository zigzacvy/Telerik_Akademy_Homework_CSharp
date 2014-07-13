using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.WordInIndex
{
    class WordInIndex
    {
        static void Main(string[] args)
        {
            string aZ = "AaBbCsDdEeFfGgHhIiJjKkLkMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

            for (int index = 0; index < aZ.Length - 1; index++)
            {
                Console.Write("{0}/{1} ", aZ[index], index);
            }

            Console.WriteLine();
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.Write("Index equivalent of the word {0} is ", word);
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < aZ.Length; j++)
                {
                    if (aZ[j] == word[i])
                    {
                        Console.Write("{0} ",j);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
