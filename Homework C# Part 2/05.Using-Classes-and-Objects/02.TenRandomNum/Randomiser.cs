using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TenRandomNum
{
    class Randomiser
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            Random randomiser = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = randomiser.Next(100, 200);
            }

            Printer(myArray);
        }

        public static void Printer(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ",array[i]);
            }
            Console.WriteLine();
        }
    }
}

//Write a program that generates and prints to the console 10 random
//values in the range [100, 200].