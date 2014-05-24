// Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class CalcTheSum
{
    static void Main()
    {
        Console.WriteLine("Entar end of sequence (1 + 1/2 - 1/3 + 1/4 - ...1/x).");
        Console.Write("x = ");
        float x = float.Parse(Console.ReadLine());

        float sum = 1.0f;

        for (float i = 2; i <= x; i++)
        {
            if (i % 2 == 1)
            {
                sum -= 1 / i;
                continue;
            }
            sum += 1 / i;
        }

        Console.WriteLine("sum = {0}",sum);
    }
}