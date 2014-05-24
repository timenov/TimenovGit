//Write a program to convert decimal numbers to their binary representation.
using System;
using System.Text;

class DecimalToBibary
{
    static void Main()
    {
        Console.Write("Enter decimal: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("to binary: {0}", Convert.ToString(number, 2));
        Console.WriteLine("to binary: {0}", ConvertToBinary(number));
    }

    static string ConvertToBinary(int number)
    {
        StringBuilder reversedBitsString = new StringBuilder();

        while (number>0)
        {
            reversedBitsString.Append(number % 2);
            number /= 2;
        }

        char[] reversedBits = reversedBitsString.ToString().ToCharArray();
        Array.Reverse(reversedBits);

        return string.Join("", reversedBits);
    }
}