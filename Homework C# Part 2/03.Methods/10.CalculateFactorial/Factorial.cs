using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.CalculateFactorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 0;
            int[] array = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
                factorial = FactorialCalc(i);
                Console.WriteLine(factorial);
            }
        }

        static BigInteger FactorialCalc(int i)
        {
            BigInteger fact = i;
            while (i > 0)
            {
                fact *= i;
                i--;
            }
            return fact;
        }
    }
}

//Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies
//a number represented as array of digits by given integer number. 