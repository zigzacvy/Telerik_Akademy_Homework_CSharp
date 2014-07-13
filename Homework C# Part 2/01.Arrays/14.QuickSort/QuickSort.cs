using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int number = int.Parse(Console.ReadLine());
            string[] unsortedArray = new string[number];
                       
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.WriteLine("Enter random latters: ");
                unsortedArray[i] = Console.ReadLine();
            }
            
            Quicksort(unsortedArray, 0, unsortedArray.Length - 1);

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.Write(unsortedArray[i] + " ");
            }

            Console.WriteLine();
        }

        public static void Quicksort(string[] elements, int left, int right)
        {
            int i = left;
            int j = right;
            string  pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    string tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
}
