//Write a program that reads a number and prints it as a
//decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.
using System;

class RightAlign
{
    static void Main()
    {
        Console.WriteLine("enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("decimal:\n{0,15}", number);
        Console.WriteLine("hexadecimal:\n{0,15:X4}", number);
        Console.WriteLine("percentage:\n{0,15:P}", number);
        Console.WriteLine("scientific:\n{0,15:E}", number);
    }
}