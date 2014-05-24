//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
using System;

class Combinations
{
    static int[] array;
    static int[] combination;
    static int k;
    static int n;

    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        array = new int[n];
        k = int.Parse(Console.ReadLine());
        combination = new int[k];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        Combs(0, 0);
    }

    static void Combs(int combIndex, int arrIndex)
    {
        if (combIndex == combination.Length)
        {
            Print();
            return;
        }
        for (int i = arrIndex; i < array.Length; i++)
        {
            combination[combIndex] = array[i];
            Combs(combIndex + 1, i + 1);
        }
    }
    static void Print()
    {
        foreach (int item in combination)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}