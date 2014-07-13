using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DecimalToBinary
{
    class DecOBin
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number you want to convert from decimal to binary: ");
            int decNum = int.Parse(Console.ReadLine());

            //If it's negative I convert it to positive, after that I just change 0s with 1s and 1s with 0s.            
            int[] binNum = new int[32];
            int testProd = Math.Abs(decNum);
            int tempProd = Math.Abs(decNum);
            if (decNum < 0)
            {
                testProd = Math.Abs(decNum + 1);
                tempProd = Math.Abs(decNum + 1);
            }

            for (int i = 31; i > 0; i--)
            {
                testProd %= 2;
                if (testProd == 0) binNum[i] = 0;
                else if (tempProd == 1) binNum[i] = 1;
                else if (tempProd == 1 || tempProd == 0) break;
                else binNum[i] = 1;
                tempProd /= 2;
                testProd = tempProd;
            }

            if (decNum < 0)
            {
                for (int i = 0; i < 32; i++)
                {
                    if (binNum[i] == 0) binNum[i] = 1;
                    else binNum[i] = 0;
                }
            }

            Printer(binNum);
        }

        public static void Printer(int[] array)
        {
            Console.Write("The binary number is ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
    }
}

//Write a program to convert decimal numbers to their binary representation.