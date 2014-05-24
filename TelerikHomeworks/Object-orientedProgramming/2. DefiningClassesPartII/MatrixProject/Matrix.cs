using System;

namespace MatrixProject
{
    class Matrix<T>
        where T : struct, IComparable, IFormattable, IConvertible, IEquatable<T>
    {
        private T[,] matrix;

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }
        public int Cols
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }
        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row > this.matrix.GetLength(0) - 1) || (col < 0 || col > this.matrix.GetLength(1) - 1))
                {
                    throw new IndexOutOfRangeException("The index is out of bounds of the matrix!");
                }
                else
                {
                    return matrix[row, col];
                }
            }
            set
            {
                if ((row < 0 || row > this.matrix.GetLength(0) - 1) || (col < 0 || col > this.matrix.GetLength(1) - 1))
                {
                    throw new IndexOutOfRangeException("The index is out of bounds of the matrix!");
                }
                else
                {
                    this.matrix[row, col] = value;
                }
            }
        }

        public Matrix(int rows, int columns)
        {
            this.matrix = new T[rows, columns];
        }
        public Matrix(T[,] array)
        {
            this.matrix = new T[array.GetLength(0), array.GetLength(1)];
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    this.matrix[row, col] = array[row, col];
                }
            }
        }


        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new FormatException("Matrices are not with same dimensions!");
            }
            else
            {
                int rows = m1.Rows;
                int cols = m1.Cols;
                Matrix<T> result = new Matrix<T>(rows, cols);
            
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        result[i, j] = (dynamic)m1[i, j] + (dynamic)m2[i, j];
                    }
                }
                return result;
            }
        }
        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new FormatException("Matrices are not with same dimensions!");
            }
            else
            {
                int rows = m1.Rows;
                int cols = m1.Cols;
                Matrix<T> result = new Matrix<T>(rows, cols);

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        result[r, c] = (dynamic)m1[r, c] - (dynamic)m2[r, c];
                    }
                }
                return result;
            }
        }
        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Cols != m2.Rows)
            {
                throw new FormatException("Matrices are not with correct dimensions!");
            }
            else
            {
                int rows = m1.Rows;
                int cols = m2.Cols;
                Matrix<T> result = new Matrix<T>(rows, cols);

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        dynamic temp = 0;
                        for (int k = 0; k < m1.Cols; k++)
                        {
                            temp += ((dynamic)m1[r, k] * (dynamic)m2[k, c]);
                        }
                        result[r, c] = temp;
                    }
                }
                return result;
            }
        }
        public static bool operator true(Matrix<T> m)
        {
            for (int row = 0; row < m.Rows; row++)
            {
                for (int col = 0; col < m.Cols; col++)
                {
                    if ((dynamic)m[row,col] != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator false(Matrix<T> m)
        {
            for (int row = 0; row < m.Rows; row++)
            {
                for (int col = 0; col < m.Cols; col++)
                {
                    if ((dynamic)m[row, col] != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
