//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
using System;

class Variations
{
    static int[] array;
    static int[] variation;
    static int n;
    static int k;

    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        k = int.Parse(Console.ReadLine());
        array = new int[n];
        variation = new int[k];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        Vars(0, 0);
    }

    static void Vars(int varIndex, int arrIndex)
    {
        if (varIndex == variation.Length)
        {
            Print();
            return;
        }
        for (int i = arrIndex; i < array.Length; i++)
        {
            variation[varIndex] = array[i];
            Vars(varIndex + 1, 0);
        }
    }
    static void Print()
    {
        foreach (int item in variation)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}