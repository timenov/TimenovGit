//Write a program to sort an array. Use the "selection sort" algorithm.

using System;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Array length: ");
        int l = int.Parse(Console.ReadLine());
        int[] array = new int[l];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int smallestIndex = array.Length - 1, nextIndex = 0;

        while (nextIndex < array.Length)
        {
            for (int i = nextIndex; i < array.Length; i++)
            {
                if (array[smallestIndex] > array[i])
                {
                    smallestIndex = i;
                }
            }
            int temp = array[nextIndex];
            array[nextIndex] = array[smallestIndex];
            array[smallestIndex] = temp;
            smallestIndex = array.Length - 1;
            nextIndex++;
        }

        foreach (int item in array)
        {
            Console.Write("{0} ",item);
        }
    }
}
