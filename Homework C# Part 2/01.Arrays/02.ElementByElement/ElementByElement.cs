using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ElementByElement
{
    class ElementByElement
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[5];
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("Enter a number: ");
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(new String('-', 20));

            int[] secondArray = new int[5];
            for (int j = 0; j < secondArray.Length; j++)
            {
                Console.Write("Enter a number: ");
                secondArray[j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(new String('-', 20));

            for (int l = 0; l < firstArray.Length; l++)
            {
                if (firstArray[l] >= secondArray[l])
                {
                    Console.WriteLine("{0} >= {1}", firstArray[l], secondArray[l]);
                }
                else
                {
                    Console.WriteLine("{0} <= {1}", firstArray[l], secondArray[l]);
                }
            }
        }
    }
}
