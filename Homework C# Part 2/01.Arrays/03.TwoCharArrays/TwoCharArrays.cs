using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TwoCharArrays
{
    class TwoCharArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of chars for Group A: ");
            string firstArray = Console.ReadLine();
            int firstLenght = firstArray.Length;
            string secondArray;
            int secondLengh;
            do
            {
                Console.WriteLine("Enter same number of different chars for Group B: ");
                secondArray = Console.ReadLine();
                secondLengh = secondArray.Length;
            }
            while (firstLenght != secondLengh);

            for (int i = 0; i < firstLenght; i++)
            {
                if ((firstArray[i].CompareTo(secondArray[i])) != 0)
                {
                    if ((firstArray[i].CompareTo(secondArray[i])) >= 1)
                    {
                        Console.WriteLine("Lexicographically, Group A is first."); break;
                    }
                    else if ((firstArray[i].CompareTo(secondArray[i])) <= 1)
                    {
                        Console.WriteLine("Lexicographically, Group B is first."); break;
                    }
                }
                else
                {
                    Console.WriteLine("Group B = Group A"); break;
                }
            }
        }
    }
}
