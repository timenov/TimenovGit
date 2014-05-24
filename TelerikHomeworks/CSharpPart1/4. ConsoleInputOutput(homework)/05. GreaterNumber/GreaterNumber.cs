// Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class GreaterNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());

        int max = first - ((first-second) & ((first-second) >> 31));

        Console.WriteLine("Greater number is: {0}", max);
    }
}