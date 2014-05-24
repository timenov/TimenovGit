//Write a program that shows the binary representation of given 16-bit signed integer number.
using System;

class SingedIntToBinary
{
    static void Main()
    {
        Console.Write("enter signed number type short: ");
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
    }
}