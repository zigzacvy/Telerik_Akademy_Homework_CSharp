using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AddPolynomials
{
    class AddPolynomials
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the degree for the first polynomials: ");
            int degreeOne = int.Parse(Console.ReadLine());
            int[] polynomOne = new int[degreeOne + 1];
            polynomOne = ArrayFiller(polynomOne);

            Console.Write("Enter the degree for the second polynomials: ");
            int degreeTwo = int.Parse(Console.ReadLine());
            int[] polynomTwo = new int[degreeTwo + 1];
            polynomTwo = ArrayFiller(polynomTwo);

            Pritner(polynomOne);
            Pritner(polynomTwo);
            Console.WriteLine("New polynomial: ");
            AddSubCalculator(polynomOne, polynomTwo);
            MultiCalculator(polynomOne, polynomTwo);
        }

        public static int[] ArrayFiller(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("x^{0}: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        public static void Pritner(int[] array)
        {
            Console.Write("The polynomial: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}x^{1} ", array[i], i);
            }
            Console.WriteLine();
        }

        public static void AddSubCalculator(int[] numberOne, int[] numberTwo)
        {
            int adding = 0;
            int subtracting = 0;


            for (int i = 0; i < (numberOne.Length) || i < (numberTwo.Length); i++)
            {
                if (i >= numberOne.Length)
                {
                    adding = numberTwo[i];
                    subtracting = numberTwo[i];
                }
                else if (i >= numberTwo.Length)
                {
                    adding = numberOne[i];
                    subtracting = numberOne[i];
                }
                else
                {
                    adding = ((numberOne[i]) + (numberTwo[i]));
                    subtracting = ((numberOne[i]) - (numberTwo[i]));
                }

                Console.Write("({0}x^{1})  ", adding, i);
                Console.WriteLine("({0}x^{1})  ", subtracting, i);
            }
            Console.WriteLine();
        }

        public static void MultiCalculator(int[] numberOne, int[] numberTwo)
        {
            int multipling = 0;
            int index = 0;

            for (int i = 0; i < numberOne.Length; i++)
            {
                for (int j = 0; j < numberTwo.Length; j++)
                {
                    multipling = numberOne[i] * numberTwo[j];
                    index = i + j;
                    Console.Write("({0}x^{1}) ",multipling,index);
                    Console.WriteLine();
                }
            }
        }
    }
}

//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5 -> 5 0 1