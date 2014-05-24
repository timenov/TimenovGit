//Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
using System;

class Permutations
{
    static int[] array;
    static int n;

    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        Perm(array.Length - 1);
    }

    static void Perm(int index)
    {
        if (index == -1)
        {
            Print();
            return;
        }
        for (int i = index; i < array.Length; i++)
        {
            Swap(i, index);
            Perm(index - 1);
            Swap(i, index);
        }
    }

    static void Print()
    {
        foreach (int item in array)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }

    static void Swap(int first, int second)
    {
        int temp = array[first];
        array[first] = array[second];
        array[second] = temp;
    }
}