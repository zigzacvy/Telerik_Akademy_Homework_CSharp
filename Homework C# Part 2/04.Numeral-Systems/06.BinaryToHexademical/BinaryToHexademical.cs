using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BinaryToHexademical
{
    class BinaryToHexademical
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the binary number you want to convert to hexademical: ");
            string binNum = Console.ReadLine();

            string[] hexNum = new string[32];
            int startBit = binNum.Length - 1;
            int tempDecNum = 0;
            int binMmltiplier = 1;
            int hexDivisor = 1;

            for (int j = hexNum.Length - 1; j > 0; j--)
            {
                if (startBit < 0) break;
                for (int i = startBit; i > startBit - 4; i--)
                {
                    if (binNum[i] == '1') tempDecNum += binMmltiplier;
                    binMmltiplier *= 2;
                }
                startBit -= 4;
                tempDecNum /= hexDivisor;

                if (tempDecNum == 10) hexNum[j] = "A";
                else if (tempDecNum == 11) hexNum[j] = "B";
                else if (tempDecNum == 12) hexNum[j] = "C";
                else if (tempDecNum == 13) hexNum[j] = "D";
                else if (tempDecNum == 14) hexNum[j] = "E";
                else if (tempDecNum == 15) hexNum[j] = "F";
                else hexNum[j] = Convert.ToString(tempDecNum);

                hexDivisor *= 16;
                tempDecNum = 0;
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

//Write a program to convert binary numbers to hexadecimal numbers (directly).