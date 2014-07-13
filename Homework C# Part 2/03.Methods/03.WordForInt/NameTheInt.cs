using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WordForInt
{
    class NameTheInt
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            NameIt(number);
        }

        private static void NameIt(int number)
        {
            int lastDigit = number % 10;
            string[] digitWords = new string[] {
                "zero","one","two","three","four",
                "five","six","seven","eight","nine"
            };
            Console.WriteLine("The name of the digit is {0}.", digitWords[lastDigit]);
        }
    }
}


//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".