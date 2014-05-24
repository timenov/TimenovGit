//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

class Factorial
{
    static void Print(int[] arr)
    {
        bool isWaste = true;
        foreach (var item in arr)
        {
            if (item == 0 && isWaste)
            {
                continue;
            }
            else if (item != 0)
            {
                isWaste = false;
                Console.Write(item);
            }
            else
            {
                Console.Write(item);
            }
        }
        Console.WriteLine();
    }
    static int[] Multiply(int[] arr, int number)
    {
        List<int> a = new List<int>();
        long reminder = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int temp = arr[i] * number;
            a.Add((int)((temp + reminder) % 10));
            reminder = (reminder + temp) / 10;
        }
        char[] reminderDigits = reminder.ToString().ToCharArray();
        for (int i = reminderDigits.Length - 1; i >= 0; i--)
        {
            int digit = int.Parse(reminderDigits[i].ToString());
            a.Add(digit);   
        }
        return ToArray(a);
    }
    static int[] ToArray(List<int> list)
    {
        int[] array = new int[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            array[i] = list[i];
        }
        return array;
    }
    static void Main()
    {
        Console.Write("enter n for n!: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = { 1 };
        for (int i = 1; i <= n; i++)
        {
            array = Multiply(array, i);
        }
        Array.Reverse(array);
        Print(array);
    }
}