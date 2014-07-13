using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BinSearch
{
    class BinSearch
    {
        static void Main(string[] args)
        {
            //Input
            Console.Write("Enter the number of the elements in the array (N): ");
            int numberN = int.Parse(Console.ReadLine());
            int[] myArray = new int[numberN];
            for (int i = 0; i < numberN; i++)
            {
                Console.Write("Enter a random element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the number K: ");
            int numberK = int.Parse(Console.ReadLine());

            //Sort and variables
            Array.Sort(myArray);
            int theSpecialOne = 0;
            
            //Search
            int IndexOfScecOne = Array.BinarySearch(myArray, numberK);            
            if (IndexOfScecOne >= 0)
            {
                theSpecialOne = myArray[IndexOfScecOne];
            }
            else
            {
                theSpecialOne = myArray[~IndexOfScecOne - 1];
            }
            Console.WriteLine(theSpecialOne);
        }
    }
}


//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.