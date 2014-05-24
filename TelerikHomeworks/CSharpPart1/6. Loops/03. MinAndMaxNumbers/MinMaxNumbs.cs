// Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
using System;

class MinMaxNumbs
{
    static void Main()
    {
        Console.Write("Enter count of numbers: ");
        int n = int.Parse(Console.ReadLine());
        
        int[] numbers = new int[n];
        Console.WriteLine("Enter sequence of {0} numbers:", n);
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int min = numbers[0], max = numbers[0];

        foreach (var number in numbers)
        {
            if (min > number)
            {
                min = number;
            }
            if (max < number)
            {
                max = number;
            }
        }
        Console.WriteLine("Minimal number is {0}.\nMaximal number is {1}.", min, max);
    }
}