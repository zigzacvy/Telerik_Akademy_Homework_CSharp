using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.AllTheVariations
{
    class AllTheVariations
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number \"N\" from [1... N]: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter the number \"K\" of elements in one variation: ");
            int K = int.Parse(Console.ReadLine());
            int[] variations = new int[K];

            Variations(variations, 0);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void Variations(int[] array, int index)
        {
            if (index == array.Length)
            {
                PrintArray(array);
            }
            else
            {
                for (int i = 1; i <= N; i++)
                {
                    array[index] = i;
                    Variations(array, index + 1);
                }
            }
        }
    }
}
