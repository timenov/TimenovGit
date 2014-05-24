// Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class FromOneToN
{
    static void Main()
    {
        Console.Write("Enter a number from 2 to 2^32: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}