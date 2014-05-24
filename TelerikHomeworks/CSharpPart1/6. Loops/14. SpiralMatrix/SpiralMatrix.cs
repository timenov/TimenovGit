//Write a program that reads a positive integer number N (N < 20) from console and 
//outputs in the console the numbers 1 ... N numbers arranged as a spiral.
using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter matrix size [row, col]:");
        Console.Write("row = ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("col = ");
        int c = int.Parse(Console.ReadLine());
        
        int[,] matrix = new int[r, c];
        int row = 0, col = 0, num = 1;
        // row and col are current row and column at the matrix, num is number to be entered
        int rowMax = r - 1, rowMin = 1, colMax = c - 1, colMin = 0;
        // rowMax is the lowermost possible row for writing, colMax - rightmost column for writing, rowMin - uppermost, colMin - leftmost
        string dir = "right";
        // dir - the advance direction 
        while (num <= r * c) //matrix size is rows * columns
        {
            matrix[row, col] = num;
            num++;
            switch (dir) //check in which direction to continue
            {
                case "down": row++;
                    if (row == rowMax)
                    {
                        rowMax--;
                        dir = "left";
                    };
                    break;
                case "right": col++;
                    if (col == colMax)
                    {
                        colMax--;
                        dir = "down";
                    };
                    break;
                case "up": row--;
                    if (row == rowMin)
                    {
                        rowMin++;
                        dir = "right";
                    };
                    break;
                case "left": col--;
                    if (col == colMin)
                    {
                        colMin++;
                        dir = "up";
                    };
                    break;
                default:
                    break;
            }
        }

        // print the matrix on Console
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write("{0,4}", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
    }
}