//Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size. 
using System;
using System.Collections.Generic;

class LargestArea
{
    private static int?[,] matrix = { { 1, 3, 2, 2, 2, 4 },
                          { 3, 3, 3, 2, 4, 4 },
                          { 4, 3, 1, 2, 3, 3 },
                          { 4, 3, 1, 3, 3, 1 },
                          { 4, 3, 3, 3, 1, 1 } };
    private static int count = 0;

    public static void FindArea(int r, int c, int? startElement)
    {
        if (r < 0 || c < 0 || r >= matrix.GetLength(0) || c >= matrix.GetLength(1) || startElement == null)
        {
            return;
        }

        if (matrix[r, c] == startElement)
        {
            matrix[r, c] = null;
            count++;
        }
        else
        {
            return;
        }
        FindArea(r, c - 1, startElement); // left
        FindArea(r, c + 1, startElement); // right
        FindArea(r - 1, c, startElement); // up
        FindArea(r + 1, c, startElement); // down
    }

    static void Main()
    {
        List<int> counts = new List<int>();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                FindArea(i, j, matrix[i, j]);
                if (count != 0)
                {
                    counts.Add(count);
                    count = 0;
                }
            }
        }
        counts.Sort();
        Console.WriteLine(counts[counts.Count - 1]); // take last element wich is the largest
    }
}