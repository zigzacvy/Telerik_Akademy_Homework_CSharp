using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaximalSum
{
    class MaximalSum
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

            int result = 0;
            int sum = 0;
            int startFrom = 0;
            int startElement = 0;
            int endElement = 0;
            int wantedElements = 0;
            //int elementCounter = 0;

            for (int j = 0; j < array.Length; j++)
            {
                sum += array[j];
                if (sum > result || (sum == result && (endElement - startElement) < (j - startFrom)))
                {
                    result = sum;                    
                    startElement = startFrom;
                    endElement = array.Length;                    
                }
                else if (sum < 0)
                {
                    sum = 0;
                    startFrom = j + 1;
                                    }
            }
            Console.Write("The maximal sum of a sequence is: ");
            Console.WriteLine(result);
            //Console.Write("The elemetns are:");
            ////for (int y = startFrom; y < elementCounter; y++)
            ////{
            ////    Console.Write(" {0}", array[y]);
            ////}
        }
    }
}
