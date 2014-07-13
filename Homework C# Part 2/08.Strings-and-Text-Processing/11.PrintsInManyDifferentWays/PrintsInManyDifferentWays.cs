using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PrintsInManyDifferentWays
{
    class PrintsInManyDifferentWays
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number :");
            int userNum = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15}",userNum);
            Console.WriteLine("{0,15:X}", userNum);
            Console.WriteLine("{0,15:P}", userNum);
            Console.WriteLine("{0,15:E}", userNum);
        }
    }
}

//Write a program that reads a number and prints it as a decimal number,
//hexadecimal number, percentage and in scientific notation. Format the 
//output aligned right in 15 symbols.