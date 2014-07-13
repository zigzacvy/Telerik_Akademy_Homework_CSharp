using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements (N): ");
            int numberN = int.Parse(Console.ReadLine());
            int[] arrayN = new int[numberN];
            for (int i = 0; i < arrayN.Length; i++)
            {
                Console.Write("Enter element: ");
                arrayN[i] = int.Parse(Console.ReadLine());
            }

            int numberK;
            do
            {
                Console.Write("Enter number of elements of the sum (K): ");
                numberK = int.Parse(Console.ReadLine());
            }
            while (numberN < numberK);

            Console.Write("The greatest elemets are: ");
            int elementsSum = 0;
            Array.Sort(arrayN);
            for (int j = (numberN - numberK); j < numberN; j++)
            {
                Console.Write("{0} ",arrayN[j]);
                elementsSum += arrayN[j];
            }
            Console.WriteLine();
            Console.WriteLine("The sum of the greatest elements is {0}.", elementsSum);
        }
    }
}
