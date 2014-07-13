using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.InTheMatrix
{
    //Task 8.
    public class Matrix<T> where T : IComparable, new()
    {
        private readonly uint rowsNum;
        private readonly uint columnsNum;
        private T[,] matrix;

        public Matrix(uint rows, uint cols)
            : this(rows, cols, new T[rows, cols])
        {
        }

        public Matrix(uint userRows, uint userColumns, T[,] userMatrix)
        {
            this.rowsNum = userRows;
            this.columnsNum = userColumns;
            this.matrix = userMatrix;
        }

        public uint GetRows
        {
            get { return this.rowsNum; }
        }

        public uint GetCols
        {
            get { return this.columnsNum; }
        }

        //Task 9.
        public T this[uint rows, uint cols]
        {
            get
            {
                if (rows < 0 || cols < 0 || rows > this.rowsNum || cols > this.columnsNum)
                {
                    throw new IndexOutOfRangeException();
                }
                return matrix[rows, cols];
            }
            set
            {
                matrix[rows, cols] = value;
            }
        }              

        //Task 10.
        public static Matrix<T> operator +(Matrix<T> leftMatrix, Matrix<T> rightMatrix)
        {
            if ((leftMatrix.GetRows != rightMatrix.GetRows) || (leftMatrix.GetCols != rightMatrix.GetCols))
            {
                throw new FormatException();
            }
            else
            {
                Matrix<T> result = new Matrix<T>(leftMatrix.GetRows, leftMatrix.GetCols);
                for (int rows = 0; rows < leftMatrix.GetRows; rows++)
                {
                    for (int j = 0; j < leftMatrix.GetCols; j++)
                    {
                        result.matrix[rows, j] = (dynamic)leftMatrix.matrix[rows, j] + (dynamic)rightMatrix.matrix[rows, j];
                    }
                }
                return result;
            }
        }

        public static Matrix<T> operator -(Matrix<T> leftMatrix, Matrix<T> rightMatrix)
        {
            if ((leftMatrix.GetRows != rightMatrix.GetRows) || (leftMatrix.GetCols != rightMatrix.GetCols))
            {
                throw new FormatException();
            }
            else
            {
                Matrix<T> result = new Matrix<T>(leftMatrix.GetRows, leftMatrix.GetCols);
                for (int rows = 0; rows < leftMatrix.GetRows; rows++)
                {
                    for (int j = 0; j < leftMatrix.GetCols; j++)
                    {
                        result.matrix[rows, j] = (dynamic)leftMatrix.matrix[rows, j] - (dynamic)rightMatrix.matrix[rows, j];
                    }
                }
                return result;
            }
        }

        public static Matrix<T> operator *(Matrix<T> leftMatrix, Matrix<T> rightMatrix)
        {
            if (leftMatrix.GetCols != rightMatrix.GetRows)
            {
                throw new FormatException();
            }
            else
            {
                uint rows = leftMatrix.GetRows;
                uint cols = rightMatrix.GetCols;
                Matrix<T> result = new Matrix<T>(rows, cols);

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        dynamic sum = 0;
                        for (int x = 0; x < cols; x++)
                        {
                            sum = sum + (dynamic)leftMatrix.matrix[row, x] * (dynamic)rightMatrix.matrix[x, col];
                        }
                        result.matrix[row, col] = sum;
                    }
                }

                return result;
            }
        }
                
        public static bool operator true(Matrix<T> userMatrix)
        {
            for (uint rows = 0; rows < userMatrix.GetRows; rows++)
            {
                for (uint cols = 0; cols < userMatrix.GetCols; cols++)
                {
                    int zero = 0;
                    if (userMatrix[rows, cols].CompareTo((T)Convert.ChangeType(zero, typeof(T))) == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> matr)
        {
            for (uint rows = 0; rows < matr.GetRows; rows++)
            {
                for (uint cols = 0; cols < matr.GetCols; cols++)
                {
                    if (matr[rows, cols].CompareTo(new T()) == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

//MANY MANY THANKS TO i.ivanov