using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number you want to convert from decimal to hexadecimal: ");
            int decNum = int.Parse(Console.ReadLine());

            string[] hexNum = new string[32];
            int testProd = decNum;
            int tempProd = decNum;

            for (int i = 31; i > 0; i--)
            {
                if (tempProd == 0) break;
                testProd %= 16;
                if (testProd == 10) hexNum[i] = "A";
                else if (testProd == 11) hexNum[i] = "B";
                else if (testProd == 12) hexNum[i] = "C";
                else if (testProd == 13) hexNum[i] = "D";
                else if (testProd == 14) hexNum[i] = "E";
                else if (testProd == 15) hexNum[i] = "F";
                else hexNum[i] = Convert.ToString(testProd);
                tempProd /= 16;
                testProd = tempProd;
            }

            Printer(hexNum);
        }

        public static void Printer(string[] array)
        {
            Console.Write("The hexademical number is ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
    }
}

//Write a program to convert decimal numbers to their hexadecimal representation.
