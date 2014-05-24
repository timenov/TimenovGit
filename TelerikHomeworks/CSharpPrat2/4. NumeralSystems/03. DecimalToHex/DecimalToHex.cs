//Write a program to convert decimal numbers to their hexadecimal representation.
using System;

class DecimalToHex
{
    const int NumSystem = 16;

    static void Main()
    {
        Console.Write("enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("to hexadecimal: {0}", Convert.ToString(number, 16).ToUpper());
        Console.WriteLine("to hexadecimal: {0}", ConvertToHex(number));
    }

    static string ConvertToHex(int number)
    {
        System.Text.StringBuilder reversedBitsString = new System.Text.StringBuilder();

        while (number > 0)
        {
            switch (number % NumSystem)
            {
                case 10:
                    reversedBitsString.Append("A");
                    break;
                case 11:
                    reversedBitsString.Append("B");
                    break;
                case 12:
                    reversedBitsString.Append("C");
                    break;
                case 13:
                    reversedBitsString.Append("D");
                    break;
                case 14:
                    reversedBitsString.Append("E");
                    break;
                case 15:
                    reversedBitsString.Append("F");
                    break;
                default:
                    reversedBitsString.Append(number % NumSystem);
                    break;
            }
            number /= 16;
        }

        char[] reversedBits = reversedBitsString.ToString().ToCharArray();
        Array.Reverse(reversedBits);

        return string.Join("", reversedBits);
    }
}