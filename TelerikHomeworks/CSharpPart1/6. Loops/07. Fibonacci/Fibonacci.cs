// Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci.
using System;

class Fibonacci
{
    static void Main()
    {
        Console.Write("Enter N members of sequence to be sum: ");
        int n = int.Parse(Console.ReadLine());

        float first = 0;
        float second = 1;
        float temp = 0; // this is a new member 0, 1, temp etc.
        float[] members = new float[n];
        members[0] = first;
        members[1] = second;

        for (int i = 2; i < n; i++)
        {
            temp = first + second;
            first = second;
            second = temp;
            members[i] = temp;
        }

        float sum = 0;
        Console.Write("Members are: ");
        foreach (var member in members)
        {
            Console.Write("{0} ", member);
            sum += member;
        }
        Console.WriteLine("\nThe sum is {0}", sum);
    }
}
