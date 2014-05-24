//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).
using System;

class CheckNeighborsMethod
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
    static void Neighbors(int[] array, int index)
    {
        if (index == 0)
        {
            Console.WriteLine("Neighbor element {0}", array[index + 1]);
        }
        else if (index == array.Length - 1)
        {
            Console.WriteLine("Neighbor element {0}", array[index - 1]);
        }
        else if (index > 0 && index < array.Length - 1)
        {
            Console.WriteLine("Neighbor elements {0} and {1}", array[index - 1], array[index + 1]);
        }
        else
        {
            Console.WriteLine("Incorrect index.");
        }
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

        Console.Write("enter index of element: ");
        int index = int.Parse(Console.ReadLine());

        Neighbors(array, index);
        Console.WriteLine("is bigger than neighbors {0}", IsBigger(array, index));
    }
}