// Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
using System;

class FactorialActions
{
    static void Main()
    {
        Console.WriteLine("Enter N and K (1<N<K):");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        float nFact = 1;
        float kFact = 1;

        double nominator, denominator;

        for (int i = 2; i <= k; i++)
        {
            kFact *= i;
            if (i <= n)
            {
                nFact *= i;
            }
        }

        denominator = 1;
        for (int i = 1; i <= (k - n); i++)
        {
            denominator *= i;
        }

        nominator = nFact * kFact;
        double result = nominator / denominator;

        Console.WriteLine("The result of N!*K!/(K-N)! is {0}", result);
    }
}