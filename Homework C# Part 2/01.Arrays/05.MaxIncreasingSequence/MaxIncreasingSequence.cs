using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxIncreasingSequence
{
    class MaxIncreasingSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a group of numbers:");
            string groupOfNumbers = Console.ReadLine();
            char element;
            int counter = 0;
            int counterMax = 0;
            char elementMax = ' ';

            for (int i = 0; i < groupOfNumbers.Length - 1; i++)
            {
                if (groupOfNumbers[i] + 1 == groupOfNumbers[i + 1])
                {
                    counter++;
                    element = groupOfNumbers[i];
                    if (counter >= counterMax)
                    {
                        counterMax = counter;
                        elementMax = element;
                    }
                }
                else
                {
                    counter = 0;
                }
            }

            elementMax++;
            for (int j = 0; j < counterMax + 1; j++)
            {
                //elementMax=elementMax - (counterMax+1);
                Console.Write("{0:x}", elementMax);
                elementMax--; //++
            }
            Console.WriteLine();
        }
    }
}
