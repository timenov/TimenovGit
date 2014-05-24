//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < n + i; j++)
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Total memory: {0}", GC.GetTotalMemory(false));
    }
}