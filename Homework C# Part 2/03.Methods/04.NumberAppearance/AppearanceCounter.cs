using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberAppearance
{
    class AppearanceCounter
    {
        static int[] array;

        static void Main(string[] args)
        {
            //Input
            Console.Write("Enter the number of elemetns: ");
            int numOfEl = int.Parse(Console.ReadLine());
            Console.Write("Enter the number you are looking for (0-9): ");
            int wantedEl = int.Parse(Console.ReadLine());

            ArrayGenerator(numOfEl);
            Console.WriteLine();
            ElementFinder(wantedEl);
        }

        //Generates an array and fills it with numbers from 0 to 9.
        public static void ArrayGenerator(int numOfEl)
        {
            array = new int[numOfEl];
            Random randomElements = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomElements.Next(0, 9);
                Console.Write("{0} ",array[i]);
            }
        }

        public static void ElementFinder(int wanterdEl)
        {
            int counter = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == wanterdEl) counter++;
            }

            if (counter == 0) Console.WriteLine("The element was not found.");
            else Console.WriteLine("{0} is found {1} times.", wanterdEl, counter);
        }
    }
}

//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.