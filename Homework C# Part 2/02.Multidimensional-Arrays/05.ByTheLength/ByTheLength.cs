using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ByTheLength
{
    class ByTheLength
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter random words:");
            string[] stringArr = Console.ReadLine().Split(' ');
            int[] elementLenght = new int[stringArr.Length];

            for (int i = 0; i < elementLenght.Length; i++)
            {
                elementLenght[i] = stringArr[i].Length;
            }
            Array.Sort(elementLenght,stringArr);
            for (int i = 0; i < elementLenght.Length; i++)
            {
                Console.Write("{0} ",stringArr[i]);
            }
            Console.WriteLine();
        }
    }
}

//You are given an array of strings. Write a method that sorts the array by the length of
//its elements (the number of characters composing them).