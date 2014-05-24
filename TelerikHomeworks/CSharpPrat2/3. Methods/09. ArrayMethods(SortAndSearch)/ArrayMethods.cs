//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.
using System;

class ArrayMethods
{
    static int FindBiggestAfter(int[] arr, int index)
    {
        int max = arr[index];
        for (int i = index; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
    static void Sort(int[] array, bool isAscending = true)
    {
        int min = 0;
        int startIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = startIndex; j < array.Length; j++)
            {
                if (array[min] > array[j])
                {
                    min = j;
                }
            }
            int temp = array[i];
            array[i] = array[min];
            array[min] = temp;
            startIndex++;
            min = startIndex;
        }
        if (!isAscending)
        {
            Array.Reverse(array);   
        }
    }
    static void Print(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] arr = { 3, 4, 2, 1, 6, 5 };
        int max = FindBiggestAfter(arr, 3);
        Sort(arr, false); //for descending order write "Sort(arr, flase);"
        Print(arr);
        Console.WriteLine(max);
    }
}