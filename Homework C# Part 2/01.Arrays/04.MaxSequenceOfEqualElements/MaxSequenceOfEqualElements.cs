using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a group of numbers with at least two sequences of equal elements:");
            string groupOfNumbers = Console.ReadLine();
            char element;
            int counter = 1;
            char mostElements=' ';
            int maxCounter = 0;

            for (int i = 0; i < groupOfNumbers.Length - 1; i++)
            {
                if (groupOfNumbers[i] == groupOfNumbers[i + 1])
                {
                    counter++;
                    element = groupOfNumbers[i];
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        mostElements = element;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            Console.WriteLine("The maximal sequence of equal elements is:");
            for (int j = 0; j < maxCounter; j++)
            {
                Console.Write(mostElements);
            }
            Console.WriteLine();
        }        
    }
}
