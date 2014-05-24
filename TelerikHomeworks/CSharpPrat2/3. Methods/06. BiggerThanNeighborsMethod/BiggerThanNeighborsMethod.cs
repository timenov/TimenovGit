//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
using System;

class BiggerThanNeighborsMethod
{
    static bool IsBigger(int[] array, int index)
    {
        bool isBigger = false;
        if (index == 0)
        {
            if (array[index] > array[index + 1])
            {
                isBigger = true;
            }
        }
        else if (index == array.Length - 1)
        {
            if (array[index] > array[index - 1])
            {
                isBigger = true;
            }
        }
        else if (index > 0 && index < array.Length - 1)
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                isBigger = true;
            }
        }
        return isBigger;
    }
    static void Main()
    {
        Console.Write("enter array length: ");
        int[] array = new int[int.Parse(Console.ReadLine())];
        Console.WriteLine("enter elements");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (IsBigger(array, i))
            {
                index = i;
                break;
            }
        }
        Console.WriteLine(index);
    }
}