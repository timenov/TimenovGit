// Write a program to calculate the Nth Catalan number by given N.
using System;

class Catalan
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
        Console.Write("Please enter N-th Catalan number: ");
        int n = int.Parse(Console.ReadLine());

        double Cn = fact(2 * n) / (fact(n + 1) * fact(n));

        Console.WriteLine("Cn = {0}", Cn);
    }
}