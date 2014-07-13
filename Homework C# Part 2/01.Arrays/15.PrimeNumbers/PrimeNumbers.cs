using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            bool[] numbers = new bool[10000001];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = true;
            }

            int max = (int)Math.Sqrt(numbers.Length);

            for (int i = 2; i <= max; i++)
            {
                if (numbers[i])
                {
                    for (int j = i * i; j < numbers.Length; j += i)
                    {
                        numbers[j] = false;
                    }
                }
            }

            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i])
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
