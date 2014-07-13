using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BiggerThanNeighbors
{
    class NeighborsSize
    {
        static int[] array;

        static void Main(string[] args)
        {
            //Input
            Console.Write("Enter the number \"N\" of elements: ");
            int elNum = int.Parse(Console.ReadLine());
            int elPosition;
            do
            {
                Console.Write("Enter the index (0 to (N-1)) of the element you want to compare: ");
                elPosition = int.Parse(Console.ReadLine());
            } while (!(elNum > elPosition));

            ArrayGenerator(elNum);
            Console.WriteLine();
            SizeChecker(elPosition);
        }

        //Generates an array and fills it with numbers from 0 to 100.
        public static void ArrayGenerator(int numOfEl)
        {
            array = new int[numOfEl];
            Random randomElements = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomElements.Next(0, 100);
                Console.Write("{0} ",array[i]);
            }
        }

        public static void SizeChecker(int positionfdEl)
        {
            if (array[positionfdEl] > array[positionfdEl - 1] &&
                array[positionfdEl] > array[positionfdEl + 1])
            {
                Console.WriteLine("The chosen element ({0}) is bigger than both it's neighbors.", array[positionfdEl]);
            }
            else if ((array[positionfdEl] < array[positionfdEl - 1] &&
                      array[positionfdEl] > array[positionfdEl + 1]) ||
                     (array[positionfdEl] > array[positionfdEl - 1] &&
                      array[positionfdEl] < array[positionfdEl + 1]))
            {
                Console.WriteLine("The chosen element ({0}) is bigger than one of it's neighbors.", array[positionfdEl]);
            }
            else Console.WriteLine("The chosen element ({0}) is smaller tha both it's neighbors.", array[positionfdEl]);
        }
    }
}


//Write a method that checks if the element at given position in given array of integers
//is bigger than its two neighbors (when such exist).