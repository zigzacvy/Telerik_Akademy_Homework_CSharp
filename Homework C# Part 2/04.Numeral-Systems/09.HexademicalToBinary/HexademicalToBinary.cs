using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.HexademicalToBinary
{
    class HexademicalToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number you want to convert from hexadecimal to decimal \n(ENTER ONLY CAPITAL LETTERS): ");
            string hexNum = Console.ReadLine();

            string binNum = " ";
            int counter = 0;

            for (int i = 0; i < hexNum.Length; i++)
            {
                counter++;
                if (hexNum[i] == '0') binNum += "0000";
                else if (hexNum[i] == '1') binNum += "0001";
                else if (hexNum[i] == '2') binNum += "0010";
                else if (hexNum[i] == '3') binNum += "0011";
                else if (hexNum[i] == '4') binNum += "0100";
                else if (hexNum[i] == '5') binNum += "0101";
                else if (hexNum[i] == '6') binNum += "0110";
                else if (hexNum[i] == '7') binNum += "0111";
                else if (hexNum[i] == '8') binNum += "1000";
                else if (hexNum[i] == '9') binNum += "1001";
                else if (hexNum[i] == 'A') binNum += "1010";
                else if (hexNum[i] == 'B') binNum += "1011";
                else if (hexNum[i] == 'C') binNum += "1100";
                else if (hexNum[i] == 'D') binNum += "1101";
                else if (hexNum[i] == 'E') binNum += "1110";
                else if (hexNum[i] == 'F') binNum += "1111";
            }

            Console.Write("The converted number is {0}.",binNum);
        }
    }
}

//Write a program to convert hexadecimal numbers to binary numbers (directly).
