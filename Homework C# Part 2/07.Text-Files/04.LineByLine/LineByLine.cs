using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LineByLine
{
    class LineByLine
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the path to the file one (..\\..\\FileName.txt): ");
            //string userPathOne = Console.ReadLine();
            //Console.Write("Enter the path to the file two(..\\..\\FileName.txt): ");
            //string userPathTwo = Console.ReadLine();

            string userPathOne = @"..\..\File1.txt";
            string userPathTwo = @"..\..\File2.txt";

            string[] userArrOne = Reader(userPathOne);
            string[] userArrTwo = Reader(userPathTwo);
            int sameCounter = Comparator(userArrOne, userArrTwo);

            Console.WriteLine(sameCounter);
        }

        public static string[] Reader(string path)
        {
            StreamReader readFromTxt = new StreamReader(path);
            using (readFromTxt)
            {
                string[] inTxtText = readFromTxt.ReadToEnd().Split('\n');

                return inTxtText;
            }
        }

        public static int Comparator(string[] arr1, string[] arr2)
        {
            int sameCounter = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i].Equals(arr2[j]))
                    {
                        sameCounter++;
                        Console.WriteLine(arr2[j]);
                    }
                }
            }

            return sameCounter;
        }
    }
}

//Not done! 
//Write a program that compares two text files line by line and prints the number of lines
//that are the same and the number
//of lines that are different. Assume the files have equal number of lines.