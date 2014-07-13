using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SelectioSort
{
    class SelectioSort
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

            Console.Write("After sorting the elements:");
            for (int i = 0; i < number; i++)
            {
                Console.Write(" {0}", array[i]);
            }
            Console.WriteLine();
        }
    }
}