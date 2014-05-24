// Write a program to print the first 100 members of the sequence of Fibonacci.

using System;

class Fibonacci
{
    static void Main()
    {
        float first = 0;
        float second = 1;
        float sum = 0;

        for (int i = 0; i < 100; i++)
        {
            sum = first + second;
            first = second;
            second = sum;
            Console.WriteLine(sum);
        }
    }
}