using System;

class FillMatrix
{
    static void Main()
    {
        Console.Write("enter \"n\" for matrix dimensions[n][n]: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("a)");
        MethodA(n);
        Console.WriteLine("b)");
        MethodB(n);
        Console.WriteLine("c)");
        MethodC(n);
        Console.WriteLine("d)");
        MethodD(n);
    }

    static void PrintMatrix(int[][] matrix)
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write("{0,2} ", matrix[row][col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void MethodA(int n)
    {
        int[][] matrix = new int[n][];
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = new int[n];
        }

        int number = 1;
        for (int col = 0; col < matrix[0].Length; col++)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row][col] = number;
                number++;
            }
        }
        PrintMatrix(matrix);
    }
    static void MethodB(int n)
    {
        int[][] matrix = new int[n][];
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = new int[n];
        }

        int number = 1;
        for (int col = 0; col < matrix[0].Length; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.Length; row++)
                {
                    matrix[row][col] = number;
                    number++;
                }
            }
            else
            {
                for (int row = matrix.Length - 1; row >= 0; row--)
                {
                    matrix[row][col] = number;
                    number++;
                }
            }
        }
        PrintMatrix(matrix);
    }
    static void MethodC(int n)
    {
        int[][] matrix = new int[n][];
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = new int[n];
        }

        int number = 1, diff = matrix.Length - 1;
        int row = matrix.Length - 1, afterMainDiag = 0;
        int diagonals = n + n - 1;
        for (int counter = 0; counter <= diagonals; counter++)
        {
            for (int i = row; i < matrix.Length - afterMainDiag; i++)
            {
                matrix[i][i - diff] = number;
                number++;
            }
            diff--;
            if (diff < 0)
            {
                afterMainDiag++;
            }
            if (row > 0)
            {
                row--;   
            }
        }
        PrintMatrix(matrix);
    }
    static void MethodD(int n)
    {
        int[][] matrix = new int[n][];
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = new int[n];
        }
        int row = 0, col = 0, num = 1;
        // row and col are current row and column at the matrix, num is number to be entered
        int rowMax = matrix.Length - 1, rowMin = 0, colMax = matrix[0].Length - 1, colMin = 1;
        // rowMax is the lowermost possible row for writing, colMax - rightmost column for writing, rowMin - uppermost, colMin - leftmost
        string dir = "down";
        // dir - the advance direction 
        while (num <= matrix.Length * matrix[0].Length) //matrix size is rows * columns
        {
            matrix[row][col] = num;
            num++;
            switch (dir) //check in which direction to continue
            {
                case "down": row++;
                    if (row == rowMax)
                    {
                        rowMax--;
                        dir = "right";
                    };
                    break;
                case "right": col++;
                    if (col == colMax)
                    {
                        colMax--;
                        dir = "up";
                    };
                    break;
                case "up": row--;
                    if (row == rowMin)
                    {
                        rowMin++;
                        dir = "left";
                    };
                    break;
                case "left": col--;
                    if (col == colMin)
                    {
                        colMin++;
                        dir = "down";
                    };
                    break;
                default:
                    break;
            }
        }
        PrintMatrix(matrix);
    }
}