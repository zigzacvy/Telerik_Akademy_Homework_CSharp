using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.InTheMatrix
{
    class TestInput
    {
        public static int[,] MatrixFiller(uint rows, uint cols, int[,] matrix)
        {
            Random randomElements = new Random();
            for (uint row = 0; row < rows; row++)
            {
                for (uint column = 0; column < cols; column++)
                {
                    matrix[row, column] = randomElements.Next(0, 10);
                }
            }

            return matrix;
        }

        static void Main(string[] args)
        {
            uint inputRows = 6;
            uint inputCols = 6;
            int[,] inputMatrix = new int[inputRows, inputCols];

            inputMatrix = MatrixFiller(inputRows, inputCols, inputMatrix);

            int[,] inputMatrixTwo = new int[6, 6];
            inputMatrixTwo = MatrixFiller(6, 6, inputMatrixTwo);

            int[,] inputMatrixTree = new int[8, 9];
            inputMatrixTree = MatrixFiller(8, 9, inputMatrixTree);

            Matrix<int> testMatrixOne = new Matrix<int>(inputRows, inputCols, inputMatrix);
            Matrix<int> testMatrixTwo = new Matrix<int>(6, 6, inputMatrixTwo);
            Matrix<int> testMatrixTree = new Matrix<int>(6, 9, inputMatrixTree);

            Matrix<int> resultSum = testMatrixOne + testMatrixTwo;
            Matrix<int> resultExtr = testMatrixOne - testMatrixTwo;
            //Matrix<int> resultExtrExeptionTest = testMatrixOne - testMatrixTree;
            Matrix<int> resultMult = testMatrixOne * testMatrixTree;

            

            Console.WriteLine();
        }
    }
}
