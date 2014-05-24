using System;

class TrailingZeros
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
        Console.Write("Insert N: ");
        int n = int.Parse(Console.ReadLine());
        double nFact = fact(n);
        int count = 0; // count zeros

        while (true)
        {
            if (nFact % 10 == 0) // if last digit is zero
            {
                count++;
                nFact /= 10; // delete last zero after count it
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("The number {0} have {1} trailing zeros at the end.",nFact * Math.Pow(10, count + 1), count);
    }
}