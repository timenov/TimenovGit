// Write a program that calculates N!/K! for given N and K (1<K<N).
using System;

class Factorials
{
    static void Main()
    {
        Console.WriteLine("Enter N and K (1<K<N):");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        long result = 1;
        
        for (int i = n; i > k; i--)
        {
            result *= i;
        }

        Console.WriteLine("Result N!/K! is {0}", result);
    }
}