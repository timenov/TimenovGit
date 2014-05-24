//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm.

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Array length: ");
        int[] array = new int[int.Parse(Console.ReadLine())];
        Console.WriteLine("array elements:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);

        Console.Write("Enter element you search: ");
        int element = int.Parse(Console.ReadLine());

        int minIndex = 0, maxIndex = array.Length - 1;
        while (maxIndex >= minIndex)
        {
            int middle = (minIndex + maxIndex) / 2;
            if (array[middle] < element)
            {
                minIndex = middle + 1;
            }
            else if (array[middle] > element)
            {
                maxIndex = middle - 1;
            }
            else
            {
                Console.WriteLine("index of {0} is {1}", element, middle);
                return;
            }
        }
        Console.WriteLine("There is no element {0}", element);
    }
}