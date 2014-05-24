//Write a program that finds the greatest of given 5 variables.
using System;

class Greatest
{
    static void Main()
    {
        Console.WriteLine("Please enter five variables:");
        Console.Write("first: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("second: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("third: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("fourth: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("fifth: ");
        int e = int.Parse(Console.ReadLine());

        int greatest = a;

        if (b > greatest)
        {
            greatest = b;
        }
        if (c > greatest)
        {
            greatest = c;
        }
        if (d > greatest)
        {
            greatest = d;
        }
        if (e > greatest)
        {
            greatest = e;
        }
        Console.WriteLine("Greatest number is {0}", greatest);
    }
}