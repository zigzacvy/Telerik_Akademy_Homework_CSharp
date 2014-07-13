using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SeparatedByTheFate
{
    class SeparatorX
    {
        static void Main(string[] args)
        {
            Console.Write("Enter random numbers separated by spaces: ");
            string[] myArray = Console.ReadLine().Split(' ');
            int sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                sum +=int.Parse(myArray[i]);                
            }

            Console.WriteLine("The sum is {0}.",sum);
        }
    }
}


//You are given a sequence of positive integer values written into a string,
//separated by spaces. Write a function that reads these values from given string
//and calculates their sum. Example: string= "43 68 9 23 318" -> result=461