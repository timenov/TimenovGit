//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;

class SeqOfGivenSum
{
    static void Main()
    {
        Console.Write("S = ");
        int sum = int.Parse(Console.ReadLine());

        Console.Write("Array length: ");
        int[] array = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

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
                if (tempSum == sum)
                {
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