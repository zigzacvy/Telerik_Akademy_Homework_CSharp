using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinaryToDecimal
{
    class BinODec
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the binary number you want to convert to decimal: ");
            string binNum = Console.ReadLine();

            int binMmltiplier = 1;
            int decNum = 0;

            for (int i = (binNum.Length-1 ); i >= 0; i--)
            {
                if (binNum[i] == '1') decNum += binMmltiplier;
                binMmltiplier *= 2;
            }

            Console.WriteLine(decNum);
        }
    }
}

//Write a program to convert binary numbers to their decimal representation.