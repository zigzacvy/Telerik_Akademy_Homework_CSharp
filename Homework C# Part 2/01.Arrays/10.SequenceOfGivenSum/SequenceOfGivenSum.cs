using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SequenceOfGivenSum
{
    class SequenceOfGivenSum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter element: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the sum S: ");
            int sum = int.Parse(Console.ReadLine());
            
            int tempSum = 0;
            int start = 0;
            int end = 0;
            bool sequenceExists = false;

            for (int i = 0; i < array.Length - 1; i++)
            {
                tempSum = array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    tempSum += array[j];
                    if (tempSum == sum)
                    {
                        sequenceExists = true;
                        start = i;
                        end = j;
                    }
                }
            }
            if (sequenceExists == false)
            {
                Console.WriteLine("There aren't serial elementes with wanted sum.");
            }
            Console.Write("The addend of the sum are: ");
            if (sequenceExists == true)
            {
                for (int l = start; l <= end; l++)
                {
                    Console.Write("{0} ", array[l]);
                }
            }
            Console.WriteLine();
        }
    }
}
