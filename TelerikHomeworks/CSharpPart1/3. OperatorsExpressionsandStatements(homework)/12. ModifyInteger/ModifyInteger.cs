// Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.

using System;

class ModifyInteger
{
    static void Main()
    {
        Console.Write("Insert number from 0 to 2^32: ");
        uint numb = uint.Parse(Console.ReadLine());

        Console.Write("Which bit you want to change: ");
        byte pos = byte.Parse(Console.ReadLine());

        Console.Write("Which is bit value bit you want (0 or 1): ");
        byte value = byte.Parse(Console.ReadLine());
        bool isZero = value == 0;

        int temp = 1 << pos;

        uint result = 0;

        if (isZero)
        {
            temp = ~temp;
            result = numb & (uint)temp;
        }
        else
        {
            result = numb | (uint)temp;
        }

        Console.WriteLine("The new number is {0}", result);
    }
}