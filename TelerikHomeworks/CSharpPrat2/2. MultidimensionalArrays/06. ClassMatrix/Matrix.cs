//Write a class Matrix, to holds a matrix of integers.
//Overload the operators for adding, subtracting and multiplying of matrices,
//indexer for accessing the matrix content and ToString().
using System;
using System.Text;

class Matrix
{
    public int rows, cols;
    private int[,] matrix;

    public Matrix(int r, int c)
    {
        matrix = new int[r, c];
        rows = r;
        cols = c;
    }

    public int this[int r, int c]
    {
        get { return matrix[r, c]; }
        set { matrix[r, c] = value; }
    }

    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        Matrix result = new Matrix(m1.rows, m1.cols);
        for (int i = 0; i < m1.rows; i++)
        {
            for (int j = 0; j < m1.cols; j++)
            {
                result[i, j] = m1[i, j] + m2[i, j];
            }
        }
        return result;
    }
    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        Matrix result = new Matrix(m1.rows, m1.cols);
        for (int i = 0; i < result.rows; i++)
        {
            for (int j = 0; j < result.cols; j++)
            {
                result[i, j] = m1[i, j] - m2[i, j];
            }
        }
        return result;
    }
    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        if (m1.cols != m2.rows)
        {
            throw new InvalidOperationException("Matricies cannot be multiplying, because columns of the first matrix are not equals with rows of the second matrix!");
        }
        else
        {
            Matrix result = new Matrix(m1.rows, m2.cols);

            for (int row = 0; row < result.rows; row++)
            {
                for (int col = 0; col < result.cols; col++)
                {
                    int element = 0;

                    for (int index = 0; index < m1.cols; index++)
                    {
                        element += m1[row, index] * m2[index, col];
                    }

                    result[row, col] = element;
                }
            }
            return result;
        }
    }
    public override string ToString()
    {
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < this.rows; i++)
        {
            for (int j = 0; j < this.cols; j++)
            {
                str.Append(this[i, j] + ", ");
            }
            str.Append("\b\0\b\b\0\n");
        }
        return str.ToString();
    }
}

class Test
{
    static void Main()
    {
        Matrix mat1 = new Matrix(3, 3);
        Matrix mat2 = new Matrix(3, 3);
        Matrix result = new Matrix(3, 3);
        Random rnd = new Random();

        for (int i = 0; i < mat1.rows; i++)
        {
            for (int j = 0; j < mat1.cols; j++)
            {
                mat1[i, j] = rnd.Next(-4, 4);
                mat2[i, j] = rnd.Next(-4, 4);
            }
        }

        Console.WriteLine(mat1.ToString());
        Console.WriteLine(mat2.ToString());
        result = mat1 + mat2;
        Console.WriteLine("adding:\n{0}", result.ToString());
        result = mat1 - mat2;
        Console.WriteLine("subtracting:\n{0}", result.ToString());
        result = mat1 * mat2;
        Console.WriteLine("multiplying:\n{0}", result.ToString());
    }
}