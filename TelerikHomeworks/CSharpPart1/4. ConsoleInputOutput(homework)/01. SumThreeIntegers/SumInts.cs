// Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class SumInts
{
    static void Main()
    {
        Console.Write("Insert first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Insert second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Insert third number: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("You entered: {0}, {1}, {2}", a, b, c);
        Console.WriteLine("The sum is: {0}", a + b + c);
    }
}