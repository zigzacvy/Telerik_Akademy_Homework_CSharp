using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number you want to convert from hexadecimal to decimal \n(ENTER ONLY CAPITAL LETTERS): ");
            string hexNum = Console.ReadLine();

            int multiplier = 1;
            int decNum = 0;

            for (int i = (hexNum.Length - 1); i >= 0; i--)
            {
                if (hexNum[i] == 'A') decNum += 10 * multiplier;
                else if (hexNum[i] == 'B') decNum += (11 * multiplier);
                else if (hexNum[i] == 'C') decNum += (12 * multiplier);
                else if (hexNum[i] == 'D') decNum += (13 * multiplier);
                else if (hexNum[i] == 'E') decNum += (14 * multiplier);
                else if (hexNum[i] == 'F') decNum += (15 * multiplier);
                else
                {
                    int num = (int)Char.GetNumericValue(hexNum[i]);
                    decNum += num * multiplier;
                }
                multiplier *= 16;
            }

            Console.WriteLine(decNum);
        }
    }
}

//Write a program to convert hexadecimal numbers to their decimal representation.