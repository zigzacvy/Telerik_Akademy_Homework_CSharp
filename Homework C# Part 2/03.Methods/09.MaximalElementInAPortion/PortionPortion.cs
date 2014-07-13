using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MaximalElementInAPortion
{
    class PortionPortion
    {
        static int maxNumber;

        static void Main(string[] args)
        {
            //Input
            Console.Write("Enter the number \"N\" of elements: ");
            int elNum = int.Parse(Console.ReadLine());
            int[] myArray = new int[elNum];

            int index = 0;
            do
            {
                Console.Write("Enter the index: ");
                index = int.Parse(Console.ReadLine());
            } while (!(index < elNum));

            Console.Write("The original array: ");
            myArray = ArrayGenerator(myArray, elNum);
            Console.WriteLine();
            maxNumber = TheMaxElOfThePortion(myArray, index);
            Console.WriteLine("The maximal number in the portion is {0}.", maxNumber);
            myArray = AscendingSort(myArray);
            Pritner(myArray);            
            myArray = TheReversingMachine(myArray);
            Pritner(myArray);            
        }

        //Generates an array and fills it with numbers from 0 to 100.
        public static int[] ArrayGenerator(int[] myArray, int elNum)
        {
            int[] array = new int[elNum];
            Random randomElements = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomElements.Next(0, 100);
                Console.Write("{0} ", array[i]);
            }
            return array;
        }

        //Finds the maximal element in the portion index, last element.
        public static int TheMaxElOfThePortion(int[] myArray, int index)
        {
            maxNumber = 0;
            for (int i = index; i < myArray.Length - 1; i++)
            {
                if (myArray[i] > maxNumber) maxNumber = myArray[i];
            }
            return maxNumber;
        }

        //Sorting using Selection sort...
        public static int[] AscendingSort(int[] myArray)
        {
            int min;
            int temp;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[j] < myArray[min])
                    {
                        min = j;
                    }
                }
                temp = myArray[i];
                myArray[i] = myArray[min];
                myArray[min] = temp;
            }
            return myArray;
        }

        //Use to print arrays.
        public static void Pritner(int[] myArray)
        {
            Console.Write("The sorted array: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(" {0}", myArray[i]);
            }
            Console.WriteLine();
        }

        //Reverse the lements of and array. Will make ascending decend :D 
        public static int[] TheReversingMachine(int[] myArray)
        {
            int[] returnArray = new int[myArray.Length];

            for (int i = 0, j = (myArray.Length - 1); i <= (myArray.Length - 1) && j >= 0; i++, j--)
            {
                returnArray[i] = myArray[j];
            }
            return returnArray;
        }
    }
}

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.