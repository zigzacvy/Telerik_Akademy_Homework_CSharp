using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.AmoreRoma
{
    class Panama
    {
        static void Main(string[] args)
        {
            string[] testStr = "asdadasd dsaasd asdsa kjasdgal;sjfg akljdgfeglkh ckhrgiyrgviy mgm".Split();

            for (int i = 0; i < testStr.Length; i++)
            {
                string palindrome = testStr[i];
                int len=palindrome.Length;
                if (palindrome[0] == palindrome[len-1])
                {
                    if(palindrome[1]==palindrome[len-2]) Console.WriteLine(palindrome);
                }
            }

            //NE! AMAN! bez regulatorni, ne iskam... xD tolkoz, neka ba4ka samo ot vreme na vreme...
        }
    }
}//Not finished.

//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".