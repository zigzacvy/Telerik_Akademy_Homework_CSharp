using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReversTheDIgits
{
    class NumberInRevers
    {
        static string number;
        static string[] tempArr;

        static void Main(string[] args)
        {
            Console.Write("Enter a random number with more than one digit: ");
            number = Console.ReadLine();

            TheReversingMachine(number);
            Console.WriteLine();
        }

        public static void TheReversingMachine(string numebr)
        {
            tempArr = new string[number.Length];
            for (int i = 0, j = (number.Length - 1); i <= (number.Length - 1) && j >= 0; i++, j--)
            {
                tempArr[i] = Convert.ToString(number[j]);
                Console.Write(tempArr[i]);
            }
        }
    }
}
 

//Write a method that reverses the digits of given decimal number. Example: 256  652