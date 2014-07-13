using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetMax
{
    class GetIt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Etner three random numbers:");
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int bigger = Calculator(firstNum, secNum);
            Console.WriteLine("The biggest number is {0}.",Calculator(bigger, thirdNum));
        }

        static int Calculator(int numOne, int numTwo)
        {
            int maxNum = 0;

            if (numOne > numTwo) maxNum = numOne;
            else maxNum = numTwo;            
            return maxNum;
        }
    }
}


//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().