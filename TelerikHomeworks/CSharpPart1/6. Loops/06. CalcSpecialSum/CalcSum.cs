// Write a program that, for a given two integer numbers N and X, calculates the sum
using System;

class CalcSum
{
    static double fact(int n)
    {
        double result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("S = 1 + 1!/X + 2!/X2 + … + N!/X^N");
        Console.WriteLine("Please enter N and X:");
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("X = ");
        int x = int.Parse(Console.ReadLine());

        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            sum += fact(i) / Math.Pow(x, i);
        }

        Console.WriteLine("sum is {0}", sum);
    }
}