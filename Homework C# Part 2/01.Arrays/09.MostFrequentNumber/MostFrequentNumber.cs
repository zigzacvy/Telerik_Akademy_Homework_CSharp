using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MostFrequentNumber
{
    class MostFrequentNumber
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

            int min;
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i]);
            //}

            int element;
            int frequentElement = 0;
            int counter = 1;
            int maxCounter = 0;
            int mostFrequentElement = 0;

            for (int j = 0; j < array.Length - 1; j++)
            {
                element = array[j];
                if (element == array[j + 1])
                {
                    frequentElement = element;
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        mostFrequentElement = frequentElement;
                    }

                }
                //else if (frequentElement != element)
                //{
                //    counter = 1;
                //}
                else
                {
                    counter = 1;
                }
            }
            Console.WriteLine("The most frequent number in this group is {0}. ", mostFrequentElement);
            Console.Write("It's found {0} times.", maxCounter);
            Console.WriteLine();
        }
    }
}

