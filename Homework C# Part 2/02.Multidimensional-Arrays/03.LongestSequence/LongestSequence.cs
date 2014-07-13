using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LongestSequence
{
    class LongestSequence
    {
        ////Print
        static void PrintMatrix(string[,] matrix)
        {
            for (int printRow = 0; printRow < matrix.GetLength(0); printRow++)
            {
                for (int printColumn = 0; printColumn < matrix.GetLength(1); printColumn++)
                {
                    Console.Write("{0,5}", matrix[printRow, printColumn]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Input
            Console.Write("Enter random number \"N\": ");
            int numberN = int.Parse(Console.ReadLine());
            Console.Write("Enter random number \"M\": ");
            int numberM = int.Parse(Console.ReadLine());
            string[,] matrixNM = new string[numberN, numberM];
            string[] randomArr = new string[] { "ha", "fifi", "ho", "hi", "xx", "xxxx", "fo", "s", "pp", "qq" };
            int row = 0;
            int column = 0;

            //You  can insert your test here. FIRST COMMENT OUT THE GENERATOR!
            //string[,] matrixNM = { };

            //Generator
            Random randomElements = new Random();
            for (row = 0; row < numberN; row++)
            {
                for (column = 0; column < numberM; column++)
                {
                    matrixNM[row, column] = randomArr[randomElements.Next(0, randomArr.Length)];
                }
            }
            PrintMatrix(matrixNM);

            int counter = 1;
            int maxCounter = 1;
            string frequentEl = " ";
            string bestFreqEl = " ";
            int onRow = 0;
            int onCol = 0;
            row = 0;
            column = 0;

            //Same elements finder: Rows check    
            for (int j = 0; j < numberN; j++)
            {
                row = j;
                for (int i = 0; i < numberM - 1; i++)
                {
                    column = i;
                    frequentEl = matrixNM[row, column];
                    if (matrixNM[row, column].Equals(matrixNM[row, column + 1]))
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            bestFreqEl = frequentEl;
                            onCol = column;
                            onRow = row;
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                }
            }

            //Same elements finder: Columns check
            for (int j = 0; j < numberM; j++)
            {
                column = j;
                for (int i = 0; i < numberN - 1; i++)
                {
                    row = i;
                    frequentEl = matrixNM[row, column];
                    if (matrixNM[row, column].Equals(matrixNM[row + 1, column]))
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            bestFreqEl = frequentEl;
                            onCol = column;
                            onRow = row;
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                }
            }

            //Same elements finder: Main diagonals check
            for (int j = 0, i = 0; j < numberN - 1 && i < numberM - 1; j++, i++)
            {
                row = j;
                column = i;
                frequentEl = matrixNM[row, column];
                if (matrixNM[row, column].Equals(matrixNM[row + 1, column + 1]))
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        bestFreqEl = frequentEl;
                        onCol = column;
                        onRow = row;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            for (int j = numberN - 1, i = 0; j > 0 && i < numberM-1; j--, i++)
            {
                row = j;
                column = i;
                frequentEl = matrixNM[row, column];
                if (matrixNM[row, column].Equals(matrixNM[row - 1, column + 1]))
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        bestFreqEl = frequentEl;
                        onCol = column;
                        onRow = row;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
           
            Console.WriteLine("The most frequent element is \"{0}\". It's found {1} times. The coordinates of the element are: {2}, {3}",
                bestFreqEl, maxCounter, onRow, onCol);
        }
        //Незавършена :/ Не минава проверка през малките диагонали.
    }
}

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets
//of several neighbor elements located on the same line, column or diagonal. Write a program 
//that finds the longest sequence of equal strings in the matrix.