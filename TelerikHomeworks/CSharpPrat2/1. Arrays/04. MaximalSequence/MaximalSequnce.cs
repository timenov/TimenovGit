//Write a program that finds the maximal sequence of equal elements in an array.

using System;

class MaximalSequnce
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int tempCount = 0, startIndex = 0, maxCount = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                tempCount++;
            }
            if (tempCount > maxCount)
            {
                maxCount = tempCount;
                startIndex = i - maxCount + 1;
            }
            if (array[i] != array[i + 1])
            {
                tempCount = 0;
            }
        }
        for (int i = startIndex; i <= startIndex + maxCount; i++)
        {
            Console.Write("{0}", array[i]);
        }
        Console.WriteLine();
    }
}