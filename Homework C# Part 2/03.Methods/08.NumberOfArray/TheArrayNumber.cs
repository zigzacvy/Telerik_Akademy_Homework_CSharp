using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NumberOfArray
{
    class TheArrayNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of digits in the first number: ");
            int elNumberOne = int.Parse(Console.ReadLine());
            int[] firstNum = new int[elNumberOne];
            ArrayFiller(firstNum);

            Console.Write("Enter the number of digits in the second number: ");
            int elNumberTwo = int.Parse(Console.ReadLine());
            int[] secondNum = new int[elNumberTwo];
            ArrayFiller(secondNum);

            firstNum = TheReversingMachine(firstNum);
            secondNum = TheReversingMachine(secondNum);
            Calculator(firstNum, secondNum);
            Console.WriteLine();
        }

        public static void ArrayFiller(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter element: ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void Calculator(int[] numberOne, int[] numberTwo)
        {
            int multiplier = 1;
            int tempSum = 0;
            int maxSum = 0;

            for (int i = 0; i < (numberOne.Length) || i < (numberTwo.Length); i++)
            {
                if (i >= numberOne.Length)
                {
                    tempSum = numberTwo[i] * multiplier;
                }
                else if (i >= numberTwo.Length)
                {
                    tempSum = numberOne[i] * multiplier;
                }
                else
                {
                    tempSum = ((numberOne[i]) + (numberTwo[i])) * multiplier;
                }

                multiplier *= 10;
                maxSum += tempSum;
            }
            Console.WriteLine("The answer is {0}.", maxSum);
        }

        public static int[] TheReversingMachine(int[] number)
        {
            int[] returnArray = new int[number.Length];
            
            for (int i = 0, j = (number.Length - 1); i <= (number.Length - 1) && j >= 0; i++, j--)
            {
                returnArray[i] = number[j];
                //Console.Write(returnArray[i]);
            }
            return returnArray;
        }
    }
}

//Write a method that adds two positive integer numbers represented as arrays of digits
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
//Each of the numbers that will be added could have up to 10 000 digits.
