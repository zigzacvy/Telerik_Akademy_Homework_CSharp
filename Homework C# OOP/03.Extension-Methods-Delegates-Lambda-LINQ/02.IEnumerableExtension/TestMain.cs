using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtension
{
    class TestMain
    {
        static void Main(string[] args)
        {
            int[] testInputInt= {4,5,6,7,3};
            float[] testInputFloat = { 0.5f, 0.6f, 0.4f };
            string[] testInputStr = { "new", "test", "input", "strstr"};

            //Sum test
            Console.WriteLine(testInputInt.Sum());
            Console.WriteLine(testInputFloat.Sum());
            Console.WriteLine(testInputStr.Sum());
            
            //Product test
            int[] testInputIntTwo = { 4, 5, 2, 2 };
            Console.WriteLine(testInputIntTwo.Product());

            //Average test
            Console.WriteLine(testInputIntTwo.Average());

            //Min test
            Console.WriteLine(testInputStr.Min());
            Console.WriteLine(testInputInt.Min());

            //Max test
            Console.WriteLine(testInputStr.Max());
        }
    }
}

//Implement a set of extension methods for IEnumerable<T> that 
//implement the following group functions: sum, product, min, max, average.
