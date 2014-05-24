//Write a program that reads a text file containing a square matrix of numbers and
//finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file. 
using System;
using System.IO;

class MaxSum
{
    static void Main()
    {
        try
        {
            StreamReader input = new StreamReader(@"../../Matrix.txt");
            using (input)
            {
                int[,] matrix;
                int dimension = int.Parse(input.ReadLine());
                matrix = new int[dimension, dimension];
                string line;
                int row = 0;
                while ((line = input.ReadLine()) != null)
                {
                    string[] numbersInString = line.Split(' ');
                    for (int index = 0; index < numbersInString.Length; index++)
                    {
                        matrix[row, index] = int.Parse(numbersInString[index]);
                    }
                    row++;
                }

                //search for max sub matrix
                int maxSum = 0;
                for (row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        int temp = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                        if (temp > maxSum)
                            maxSum = temp;
                    }
                }

                using (StreamWriter output = new StreamWriter(@"../../Answert.txt"))
                {
                    output.Write(maxSum);
                }
                Console.WriteLine("Done.");
            }
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}