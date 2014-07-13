using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SquareMatrix
{
    class SquareMatrix
    {
        static int bestRow = 0;
        static int bestColumn = 0;

        static void Main(string[] args)
        {
            string userPath = @"..\..\TestFile.txt";

            string[] stringArr = Reader(userPath);
            int[,] userMatrix = Converter(stringArr);
            int result = Calculator(userMatrix);
            Printer(result, userMatrix);

            Console.WriteLine(result);
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

        public static int[,] Converter(string[] arr)
        {
            int[,] sqrMatrix = new int[arr.Length, arr[1].Length];

            for (int row = 0; row < arr.Length; row++)
            {
                for (int column = 0; column < arr[row].Length - 1; column++)
                {
                    sqrMatrix[row, column] = int.Parse(arr[row][column].ToString());

                }
            }

            return sqrMatrix;
        }

        public static int Calculator(int[,] matrix)
        {
            int bestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int column = 0; column < matrix.GetLength(1) - 2; column++)
                {
                    int sum = matrix[row, column] + matrix[row, column + 1] +
                        matrix[row + 1, column] + matrix[row + 1, column + 1];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestColumn = column;
                    }
                }
            }

            return bestSum;
        }

        public static void Printer(int answer, int[,] matrix)
        {
            Console.WriteLine("Maximal sum is: {0}", answer);
            Console.WriteLine("The platform with maximal sum is is: ");
            Console.WriteLine("{0,2}{1,2}",
                matrix[bestRow, bestColumn],
                matrix[bestRow, bestColumn + 1]);
            Console.WriteLine("{0,2}{1,2}",
                matrix[bestRow + 1, bestColumn],
                matrix[bestRow + 1, bestColumn + 1]);
        }
    }
}

//Write a program that reads a text file containing a square matrix of numbers and finds in
//the matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in the
//input file contains the size of matrix N. Each of the next N lines contain N numbers
//separated by space. The output should be a single number in a separate text file. Example:
