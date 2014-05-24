//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaxSum
{
    static int[] array;
    static int[] kArray;
    static int[] answer;
    static int sum = 0;

    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        kArray = new int[k];
        answer = new int[k];
        
        array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Recursion(0, 0);

        foreach (int item in answer)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }

    static void Recursion(int arrayIndex, int kArrayIndex)
    {
        if (kArrayIndex == kArray.Length)
        {
            Print();
            return;
        }
        for (int i = arrayIndex; i < array.Length; i++)
        {
            kArray[kArrayIndex] = array[i];
            Recursion(i + 1, kArrayIndex + 1);
        }
    }
    static void Print()
    {
        int tempSum = 0;
        foreach (int item in kArray)
        {
            tempSum += item;
        }
        if (tempSum > sum)
        {
            sum = tempSum;
            kArray.CopyTo(answer, 0);
        }
    }
}