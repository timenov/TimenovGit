// Write an expression that checks if given positive integer number n (n ≤ 100) is prime.

using System;

class IsPrime
{
    static void Main()
    {
        Console.Write("Please insert number from 0 to 100: ");

        byte numb = byte.Parse(Console.ReadLine());

        bool isPrime = true;

        for (int i = 2; i <= Math.Sqrt(numb); i++)
        {
            if (numb % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine("Number is prime. {0}", isPrime);
    }
}