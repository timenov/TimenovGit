// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        uint numb = uint.Parse(Console.ReadLine());
            
        uint sMask = 7 << 3; // s from small
        uint bMask = 7 << 23; // b from big

        uint xOrMasks = sMask ^ bMask;
        uint xOrMasksAndNumb = xOrMasks & numb;
            
        uint numbAndSMask = numb & sMask;
        uint numbAndBMask = numb & bMask;
            
        uint temp = (numbAndSMask << 20) ^ (numbAndBMask >> 20);

        uint tempXORNumb = temp ^ numb;

        uint finalResult = tempXORNumb ^ xOrMasksAndNumb;
            
        Console.WriteLine("Enter Number: {0}", Convert.ToString(numb, 2).PadLeft(32, '0'));
        Console.WriteLine("Change Number:{0}", Convert.ToString(finalResult, 2).PadLeft(32, '0'));
        Console.WriteLine(finalResult);
    }
}