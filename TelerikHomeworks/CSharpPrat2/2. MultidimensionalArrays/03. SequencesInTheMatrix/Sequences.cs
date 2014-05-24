//We are given a matrix of strings of size N x M.
//Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix. 
using System;

class Sequences
{
    static void Main()
    {
        Console.WriteLine("insert matrix dimensions:");
        Console.Write("rows = ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("cols = ");
        int c = int.Parse(Console.ReadLine());
        // initialize matrix[r][c]
        string[][] matrix = new string[r][];
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = new string[c];
        }
        // filling matrix
        Console.Clear();
        PrintWholeMatrix(matrix);
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = Console.ReadLine();
                Console.Clear();
                PrintWholeMatrix(matrix);
            }
        }

        int[][] data = new int[3][];
        int[] finalData = new int[4];
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                data[0] = CheckHorizontally(matrix, row, col);
                data[1] = CheckVertically(matrix, row, col);
                data[2] = CheckDiagonal(matrix, row, col);
                int[] temp = CheckAllData(data);
                if (temp[3] > finalData[3])
                {
                    temp.CopyTo(finalData, 0);
                }
            }
        }
        Console.WriteLine();
        PrintAnswer(matrix, finalData);
    }
    static int[] CheckHorizontally(string[][] matrix, int r, int c)
    {
        int[] data = { 0, 0, 0, 0 }; //data[0]-direction, data[1]-start[row], data[2]-start[col], data[3]-counts
        string temp = matrix[r][c];
        int counter = 0;
        for (int i = 0; i + c < matrix[r].Length; i++)
        {
            if (temp.Equals(matrix[r][c + i]))
            {
                counter++;
                temp = matrix[r][c + i];
            }
            else
            {
                break;
            }
        }
        data[1] = r;
        data[2] = c;
        data[3] = counter;
        return data;
    }
    static int[] CheckVertically(string[][] matrix, int r, int c)
    {
        int[] data = { 1, 0, 0, 0 }; //data[0]-direction, data[1]-start[row], data[2]-start[col], data[3]-counts
        string temp = matrix[r][c];
        int counter = 0;
        for (int i = 0; i + r < matrix.Length; i++)
        {
            if (temp.Equals(matrix[r + i][c]))
            {
                counter++;
                temp = matrix[r + i][c];
            }
            else
            {
                break;
            }
        }
        data[1] = r;
        data[2] = c;
        data[3] = counter;
        return data;
    }
    static int[] CheckDiagonal(string[][] matrix, int r, int c)
    {
        int[] data = { 2, 0, 0, 0 }; //data[0]-dir, data[1]-start[row], data[2]-start[col], data[3]-counts
        string temp = matrix[r][c];
        int counter = 0;
        for (int i = 0; i + r < matrix.Length && i + c < matrix[0].Length; i++)
        {
            if (temp.Equals(matrix[r + i][c + i]))
            {
                counter++;
                temp = matrix[r + i][c + i];
            }
            else
            {
                break;
            }
        }
        data[1] = r;
        data[2] = c;
        data[3] = counter;
        return data;
    }
    static int[] CheckAllData(int[][] allData)
    {
        int maxCount = 0;
        int iMax = 0;
        for (int i = 0; i < 3; i++)
        {
            if (allData[i][3] > maxCount)
            {
                iMax = i;
                maxCount = allData[i][3];
            }
        }
        return allData[iMax];
    }
    static void PrintAnswer(string[][] matrix, int[] data)
    {
        int row = data[1], col = data[2];
        switch (data[0])
        {
            case 0:
                for (int i = 0; i < data[3]; i++)
                {
                    Console.Write("{0}, ", matrix[row][col + i]);
                }
                break;
            case 1:
                for (int i = 0; i < data[3]; i++)
                {
                    Console.Write("{0}, ", matrix[row + i][col]);
                }
                break;
            case 2:
                for (int i = 0; i < data[3]; i++)
			    {
			        Console.Write("{0}, ", matrix[row + i][col + i]);
			    }
                break;
        }
        Console.WriteLine("\b\b\0");
    }
    static void PrintWholeMatrix(string[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            Console.Write("||");
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write(" {0,4} |", matrix[i][j]);
            }
            Console.WriteLine("\b||");
            Console.WriteLine(new string('=', matrix[i].Length * 7 + 3));
        }
    }
}