using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DivisibleBy
{
    class TestMain
    {
        static void Main(string[] args)
        {
            int[] userInput = new int[30];

            ArrayFiller(userInput);

            Method output = new Method(userInput);
            output.DivisibleBy();
            Console.WriteLine("LINQ ---------");
            output.DivisbleByLinq();
        }

        public static int[] ArrayFiller(int[] userArray)
        {
            Random randomElements = new Random();

            for (uint i = 0; i < userArray.Length; i++)
                {
                    userArray[i] = randomElements.Next(1, 100);
                }
            
            return userArray;
        }
    }
}


//Write a program that prints from given array of integers all numbers
//that are divisible by 7 and 3. Use the built-in extension methods and
//lambda expressions. Rewrite the same with LINQ.