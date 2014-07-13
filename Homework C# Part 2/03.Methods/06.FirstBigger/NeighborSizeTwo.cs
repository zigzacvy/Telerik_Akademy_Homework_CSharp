using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FirstBigger
{
    class NeighborSizeTwo
    {
        static int[] array;

        static void Main(string[] args)
        {
            //Input
            Console.Write("Enter the number \"N\" of elements: ");
            int elNum = int.Parse(Console.ReadLine());

            ArrayGenerator(elNum);
            Console.WriteLine();
            SizeChecker(array);
        }

        //Generates an array and fills it with numbers from 0 to 100.
        public static void ArrayGenerator(int numOfEl)
        {
            array = new int[numOfEl];
            Random randomElements = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomElements.Next(0, 100);
                Console.Write("{0} ", array[i]);
            }
        }

        public static void SizeChecker(int[] array)
        {
            int tempBestEl = 0;
            int bestEl = 0;
            bool thereIsNot = true;

            for (int i = 1; i < (array.Length - 1); i++)
            {
                if (array[i] > array[i - 1] &&
                    array[i] > array[i + 1])
                {
                    tempBestEl = array[i];
                    if (tempBestEl > bestEl) bestEl = tempBestEl;
                    thereIsNot = false;
                }
            }
            if (thereIsNot == true) Console.WriteLine("There isn't such element.");
            else Console.WriteLine("The greatest bigger tha it's neighbors elements is {0}.", bestEl);
        }
    }
}

//Write a method that returns the index of the first element in array that is bigger than its neighbors,
//or -1, if there’s no such element.
//Use the method from the previous exercise.