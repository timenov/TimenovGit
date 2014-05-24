//Write a program to convert binary numbers to their decimal representation.
using System;

class BinaryToDecimal
{
    const int NumSystem = 2;

    static void Main()
    {
        Console.Write("Enter binary number: ");
        string input = Console.ReadLine();
        Console.WriteLine("to decimal: {0}", Convert.ToInt32(input, 2));
        Console.WriteLine("to decimal: {0}", ConvertToDecimal(input));
    }

    static int ConvertToDecimal(string input)
    {
        int power = 0;
        int output = 0;

        for (int bit = input.Length - 1; bit >= 0; bit--)
        {
            int currBit = int.Parse(input[bit].ToString());
            output += currBit * (int)(Math.Pow(NumSystem, power));
            power++;
        }

        return output;
    }
}