using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillAndPrint
{
    class FillAndPrint
    {
        //Print
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
            Console.Write("Enter the number \"n\": ");
            int numberN = int.Parse(Console.ReadLine());
            int[,] matrixN = new int[numberN, numberN];

            int row = 0;
            int column = 0;
            int element = 1;
            int fuckShitUp = 1;
            int end = numberN * numberN;
            int rowUp = numberN - 1;

            //a
            for (int i = 0; i < end + (numberN - 1); i++)
            {
                if (row < numberN)
                {
                    matrixN[column, row] = element;
                    row++;
                    element += numberN;
                }
                else
                {
                    column++;
                    row = 0;
                    element = fuckShitUp + 1;
                    fuckShitUp = element;
                }
            }
            PrintMatrix(matrixN);
            Console.WriteLine();

            //b
            row = 0;
            column = 0;
            for (int i = 1; i <= end; i++)
            {
                if (column % 2 == 0)
                {
                    matrixN[row, column] = i;
                    row++;
                    if (row == numberN)
                    {
                        row = 0;
                        column++;
                    }
                }
                else
                {
                    matrixN[rowUp, column] = i;
                    rowUp--;
                    if (rowUp < 0)
                    {
                        rowUp = numberN - 1;
                        column++;
                    }
                }
            }
            PrintMatrix(matrixN);
            Console.WriteLine();

            //c
            int counter = 1;

            for (row = 0; row <= numberN - 1; row++)
            {
                for (column = 0; column <= row; column++)
                {
                    matrixN[numberN - row + column - 1, column] = counter++;
                }
            }

            for (row = numberN - 2; row >= 0; row--)
            {
                for (column = row; column >= 0; column--)
                {
                    matrixN[row - column, numberN - column - 1] = counter++;
                }
            }
            PrintMatrix(matrixN);
            Console.WriteLine();
        }
    }
}

//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)