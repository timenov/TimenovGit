//Write a program that reads a string, reverses it and prints the result at the console.

using System;

class RevString
{
    static void Main()
    {
        Console.Write("input some text here: ");
        string input = Console.ReadLine();
        Console.Write("reversed: ");
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
        Console.WriteLine();
    }
}