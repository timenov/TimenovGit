//Write a program that finds the sequence of maximal sum in given array.

using System;

class SeqOfMaxSum
{
    static void Main()
    {
        Console.Write("Array length: ");
        int[] array = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxSum = 0;
        int lastIndex = 0;
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            int tempCount = 0;
            int tempSum = 0;
            for (int j = i; j < array.Length; j++)
            {
                tempSum += array[j];
                tempCount++;
                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                    lastIndex = j;
                    count = tempCount;
                }
            }
        }

        for (int i = (lastIndex - count + 1); i <= lastIndex; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}