using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ManyTasks
{
    class ManyTasks
    {
        static string revNumber;
        static string[] tempArr;

        static void Main(string[] args)
        {
            Console.WriteLine(@"Enter 1 for reversing a numbers digits, enter 2 for
calculating avarage of an sequence, enter 3 for lenear
equation.");

            int number=1;
            do
            {
                Console.Write("Enter 1, 2 or 3: ");
                number = int.Parse(Console.ReadLine());
            } while (number > 3);

            switch (number)
            {
                case 1:                    
                   Console.Write("Enter a random number with more than one digit: ");
                   revNumber = Console.ReadLine();
                   TheReversingMachine(revNumber);
                   Console.WriteLine(); break;
                    
                case 2:
                      Console.WriteLine("Enter number of elemnts: ");
                      int elNum = int.Parse(Console.ReadLine());
                      int[] array = new int[elNum];
                      array = ArrayGenerator(array, elNum);
                      AverageCalc(array); break;

                case 3:
                    Console.Write("Enter number a: ");
                    float numberA=float.Parse(Console.ReadLine());
                    Console.Write("Enter number b: ");
                    float numberB=float.Parse(Console.ReadLine());
                    LinearEquation(numberA,numberB); break;
            }
               
        }

        public static void TheReversingMachine(string revNum)
        {
            tempArr = new string[revNumber.Length];
            for (int i = 0, j = (revNumber.Length - 1); i <= (revNumber.Length - 1) && j >= 0; i++, j--)
            {
                tempArr[i] = Convert.ToString(revNumber[j]);
                Console.Write(tempArr[i]);
            }
        }

        public static void AverageCalc(int[] myArray)
        {
            float sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }

            float average = (sum / myArray.Length);
            Console.WriteLine("The average is {0}.", average);
        }

        public static void LinearEquation(float a, float b)
        {
            float answer = (-b) / a;
            Console.WriteLine("The answer is {0}.", answer);
        }

        public static int[] ArrayGenerator(int[] myArray, int elNum)
        {
            int[] array = new int[elNum];
            Random randomElements = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomElements.Next(1, 9);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            return array;
        }
    }
}

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//		Create appropriate methods.
//		Provide a simple text-based menu for the user to choose which task to solve.
//		Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0