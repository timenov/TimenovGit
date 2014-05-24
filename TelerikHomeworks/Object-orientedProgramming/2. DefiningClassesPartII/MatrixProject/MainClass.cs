using System;

namespace MatrixProject
{
    class MainClass
    {
        private static int[,] m1 = new int[,] { { 1, -1, 0 } ,
                                                { 0, 2, 3 } ,
                                                { 1, -3, 1 } ,
                                                { 4, 0, 2 } };

        private static int[,] m2 = new int[,] { { 2, 1 } ,
                                                { -1, 0 } ,
                                                { 3, 1 } };

        private static int[,] m3 = new int[,] { { 1, 2 } ,
                                                { 3, 4 } ,
                                                { -2, -4} };
        public static void Main()
        {
            Matrix<int> m = new Matrix<int>(m3);
            Matrix<int> n = new Matrix<int>(m2);

            Matrix<int> mn = m + n;
            PrintMatrix(mn);
            Console.WriteLine();

            mn = m - n;
            PrintMatrix(mn);
            Console.WriteLine();

            m = new Matrix<int>(m1);
            mn = m * n;
            PrintMatrix(mn);
        }

        public static void PrintMatrix<T>(Matrix<T> matrix) where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
