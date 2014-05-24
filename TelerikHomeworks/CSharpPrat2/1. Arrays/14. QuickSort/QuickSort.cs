//Write a program that sorts an array of strings using the quick sort algorithm.

using System;

class QuickSort
{
    static void Main()
    {
        Console.Write("Array length: ");
        int[] array = new int[int.Parse(Console.ReadLine())];
        Console.WriteLine("enter elements:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        sort(array, 0, array.Length - 1);

        foreach (int item in array)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
    static void sort(int[] array, int l, int r)
    {

        if (l >= r)
        {
            return;
        }

        int i = l;
        int j = r;
        int p = array[r];

        while (i < j)
        {
            while (i < j && array[i] <= p)
            {
                i++;
            }

            while (i < j && array[j] >= p)
            {
                j--;
            }

            if (i < j)
            {
                int tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;

            }
        }
        int temp = array[i];
        array[i] = array[r];
        array[r] = temp;

        sort(array, l, i - 1);
        sort(array, i + 1, r);
    }
}