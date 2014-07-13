using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MinMaxWatheva
{
    class MinMax
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elemnts: ");
            int elNum = int.Parse(Console.ReadLine());
            int[] array = new int[elNum];
            array = ArrayGenerator(array, elNum);

            MaxMinProductAndSumCalc(array);
            AverageCalc(array);
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

        public static void MaxMinProductAndSumCalc(int[] myArray)
        {
            int max = 0;
            int min = myArray[0];
            int sum = 0;
            int product = 1;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > max) max = myArray[i];
                else if (myArray[i] < min) min = myArray[i];
                sum += myArray[i];
                product *= myArray[i];
            }
            Console.Write("min = {0}, max = {1}, sum = {2}, product = {3}", min, max, sum, product);
        }

        public static void AverageCalc(int[] myArray)
        {
            float sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }
            
            float average=(sum/myArray.Length);
            Console.WriteLine(" average = {0}", average);
        }
    }
}

//Write methods to calculate minimum, maximum, average,
//sum and product of given set of integer numbers. Use variable number of arguments.