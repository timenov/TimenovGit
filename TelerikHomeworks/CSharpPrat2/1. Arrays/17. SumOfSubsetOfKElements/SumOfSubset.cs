//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.
using System;

class SumOfSubset
{
    static int[] numbers;
    static int k;
    static int[] readyComb;
    static int sum;

    static void Main()
    {
        Console.Write("Array length: ");
        int size = int.Parse(Console.ReadLine());
        numbers = new int[size];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("n{0} = ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.Write("enter K = ");
        k = int.Parse(Console.ReadLine());
        Console.Write("enter S = ");
        sum = int.Parse(Console.ReadLine());

        readyComb = new int[k];
        recursion(0, 0);
    }

    static void printComb()
    {
        if (calculate(readyComb) == sum)
        {
            foreach (var combos in readyComb)
            {
                Console.Write("{0} ", combos);
            }
            Console.WriteLine();
        }
    }
    static int calculate(int[] array)
    {
        int result = 0;
        foreach (var n in array)
        {
            result += n;
        }
        return result;
    }

    static void recursion(int indexReadyComb, int numbersIndex)
    {
        if (indexReadyComb == k)
        {
            printComb();
            return;
        }
        for (int i = numbersIndex; i < numbers.Length; i++)
        {
            readyComb[indexReadyComb] = numbers[i];
            recursion(indexReadyComb + 1, i + 1);
        }
    }
}