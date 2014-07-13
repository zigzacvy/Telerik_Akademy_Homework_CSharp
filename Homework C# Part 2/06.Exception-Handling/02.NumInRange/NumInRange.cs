using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumInRange
{
    class NumInRange
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start number: ");
            int userStart = int.Parse(Console.ReadLine());
            Console.Write("Enter end number: ");
            int userEnd = int.Parse(Console.ReadLine());
            int userNum = 0;

            for (int i = 0; i < 10; i++)
            {
                userNum = ReadNumber(userStart, userEnd);
                userStart = userNum;
            }
        }

        public static int ReadNumber(int start, int end)
        {
            int number = 0;

            try
            {
                number = int.Parse(Console.ReadLine());
            }           
            catch (FormatException)
            {
                Console.WriteLine("Invalid entry!");
            }

            //С "по- разбираемо" съобщение. 

            //Exception ArgumentOutOfRange = new Exception("Invalid number!");

            //if (number < start || number > end)
            //{
            //    throw ArgumentOutOfRange;                
            //}

            if (number < start || number > end)
            {
                throw new ArgumentOutOfRangeException;
            }

            return number;
        }
    }
}

//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers:
//			a1, a2, … a10, such that 1 < a1 < … < a10 < 100