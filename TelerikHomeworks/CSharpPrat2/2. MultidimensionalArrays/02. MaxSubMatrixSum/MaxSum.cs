//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
using System;

class MaxSum
{
    static void Main()
    {
        Console.Write("enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("enter M: ");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        int subMatSize = 3;
        int sum = 0, maxSum = 0;
        int rowMax = 0, colMax = 0;
        //take element with address matrix[row, col] who is first element of submatrix
        for (int row = 0; row <= n - subMatSize; row++)
        {
            for (int col = 0; col <= m - subMatSize; col++)
            {
                //iterate submatrix elements and sum it
                for (int subRow = row; subRow < row + subMatSize; subRow++)
                {
                    for (int subCol = col; subCol < col + subMatSize; subCol++)
                    {
                        sum += matrix[subRow, subCol];
                    }
                }
                if (sum > maxSum)
                {
                    rowMax = row;
                    colMax = col;
                    maxSum = sum;
                }
                sum = 0;
            }
        }

        //print hole matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //print max sum matrix
        for (int row = rowMax; row < rowMax + subMatSize; row++)
        {
            for (int col = colMax; col < colMax + subMatSize; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}