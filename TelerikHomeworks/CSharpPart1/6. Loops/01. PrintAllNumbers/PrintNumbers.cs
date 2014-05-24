// Write a program that prints all the numbers from 1 to N.
using System;

class PrintNumbers
{
    static void Main()
    {
        Console.Write("Please enter number in range [1..1 000 000]: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}