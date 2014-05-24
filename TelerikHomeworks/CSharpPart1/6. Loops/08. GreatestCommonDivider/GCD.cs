//Write a program that calculates the greatest common divisor (GCD) of given two numbers.
using System;

class GCD
{
    static void GCDRecursive(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("GCD is {0}", a);
            return;
        }

        double yy = b;
        while (a - yy > b)
        {
            yy += b;
        }
        double temp = a - yy;
        GCDRecursive(b, temp);
    }

    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        Console.Write("first: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("second: ");
        int b = int.Parse(Console.ReadLine());

        if (a < b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        GCDRecursive(a, b);
    }
}