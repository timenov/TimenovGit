//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be filled with '*'.
//Print the result string into the console.
using System;
using System.Collections.Generic;

class FillTheString
{
    static void Main()
    {
        Console.Write("input string (less than 20 characters): ");
        string input = Console.ReadLine();
        Console.WriteLine(Convert.ToString(input).PadRight(20, '*'));
    }
}