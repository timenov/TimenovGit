// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class FindingBit
{
    static void Main()
    {
        Console.Write("Please insert a number between -2^31 and 2^31: ");

        int numb = int.Parse(Console.ReadLine());
        int check = 8; // 8 in binary 1000

        int temp = numb & check;

        bool isZero = temp == 0;

        Console.WriteLine("Is bit number 3 (counting from 0) is zero: {0}", isZero);
    }
}
