using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];

            Random randomElements = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomElements.Next(1, 101);
            }

            Array.Sort(array);

            Console.Write("The list of numbers is: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write("{0} ", array[j]);
            }
            Console.WriteLine();

            Console.Write("Select the element which index you want to find: ");
            int searchFor = int.Parse(Console.ReadLine());

            int start = 0;
            int end = array.Length-1;
            int center = 0;            

            for (int l = 0; l < array.Length - 1; l++)
            {
                center = start + (end - start) / 2;
                                
                if (searchFor == array[center])
                {
                    Console.WriteLine("The index of the element you search for is {0}.", center); break;
                }
                else if (searchFor < array[center])
                {
                    end = center - 1;
                }
                else
                {
                    start = center + 1;
                }
            }                        
        }
    }
}
