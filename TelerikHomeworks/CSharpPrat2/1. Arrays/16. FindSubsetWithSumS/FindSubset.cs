//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.

using System;

class FindSubset
{
    static int[] numbers;
    static int combinations;
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
        Console.Write("enter S = ");
        sum = int.Parse(Console.ReadLine());

        for (int i = 2; i <= numbers.Length; i++)
        {
            combinations = i;
            readyComb = new int[i];
            recursion(0, 0);
        }
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
        if (indexReadyComb == combinations)
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