//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
using System;

class StringToUnicode
{
    static void Main()
    {
        Console.WriteLine("enter some text:");
        string input = Console.ReadLine();

        foreach (char character in input)
        {
            Console.Write("\\u{0:X4}", (int)character);
        }
        Console.WriteLine();
    }
}