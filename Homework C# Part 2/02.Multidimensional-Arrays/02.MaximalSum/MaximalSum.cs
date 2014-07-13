using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaximalSum
{
    class MaximalSum
    {
        static void PrintMatrix(int[,] matrix)
        {
            for (int printRow = 0; printRow < matrix.GetLength(0); printRow++)
            {
                for (int printColumn = 0; printColumn < matrix.GetLength(1); printColumn++)
                {
                    Console.Write("{0,4}", matrix[printRow, printColumn]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int numberN;
            do
            {
                Console.Write("Enter random number \"N\" bigger than 3: ");
                numberN = int.Parse(Console.ReadLine());
            }
            while (numberN <= 3);
            int numberM;
            do
            {
                Console.Write("Enter random number \"M\" bigger than 3: ");
                numberM = int.Parse(Console.ReadLine());
            }
            while (numberM <= 3);
            int[,] matrixNM = new int[numberN, numberM];

            //Generator
            Random randomElements = new Random();
            for (int row = 0; row < numberN; row++)
            {
                for (int column = 0; column < numberM; column++)
                {
                    matrixNM[row, column] = randomElements.Next(1, 10);
                }
            }
            PrintMatrix(matrixNM);

            //Calculator
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestColumn = 0;

            for (int row = 0; row < matrixNM.GetLength(0) - 2; row++)
            {
                for (int column = 0; column < matrixNM.GetLength(1) - 2; column++)
                {
                    int sum = matrixNM[row, column] + matrixNM[row, column + 1] +
                        matrixNM[row, column + 2] + matrixNM[row + 1, column] +
                        matrixNM[row + 1, column + 1] + matrixNM[row + 1, column + 2] +
                        matrixNM[row + 2, column] + matrixNM[row + 2, column + 1] +
                        matrixNM[row + 2, column + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestColumn = column;
                    }
                }
            }

            //Print
            Console.WriteLine("Maximal sum is: {0}", bestSum);
            Console.WriteLine("The platform with maximal sum is is: ");
            Console.WriteLine("{0,2}{1,2}{2,2}",
                matrixNM[bestRow, bestColumn],
                matrixNM[bestRow, bestColumn + 1],
                matrixNM[bestRow, bestColumn + 2]);
            Console.WriteLine("{0,2}{1,2}{2,2}",
                matrixNM[bestRow + 1, bestColumn],
                matrixNM[bestRow + 1, bestColumn + 1],
                matrixNM[bestRow + 1, bestColumn + 2]);
            Console.WriteLine("{0,2}{1,2}{2,2}",
                matrixNM[bestRow + 2, bestColumn],
                matrixNM[bestRow + 2, bestColumn + 1],
                matrixNM[bestRow + 2, bestColumn + 2]);
        }
    }
}

//Write a program that reads a rectangular matrix of size N x M 
//and finds in it the square 3 x 3 that has maximal sum of its elements.