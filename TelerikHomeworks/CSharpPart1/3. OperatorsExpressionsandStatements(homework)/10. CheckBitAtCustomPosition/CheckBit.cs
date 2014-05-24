// Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1.

using System;

class CheckBit
{
    static void Main()
    {
        Console.Write("Insert number from 0 to 2^32: ");
        int numb = int.Parse(Console.ReadLine());

        Console.Write("Insert position of bit that you want to check: ");
        byte pos = byte.Parse(Console.ReadLine());

        int temp = 1 << pos;

        bool isOne = (numb & temp) != 0;

        Console.WriteLine("Bit number {0} of integer {1} is one. {2}", pos, numb, isOne);
    }
}