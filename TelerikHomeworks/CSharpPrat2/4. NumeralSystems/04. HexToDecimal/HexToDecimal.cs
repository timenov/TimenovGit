//Write a program to convert hexadecimal numbers to their decimal representation.
using System;

class HexToDecimal
{
    const int NumSystem = 16;

    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string input = Console.ReadLine();
        Console.WriteLine(Convert.ToInt32(input, 16));
        Console.WriteLine(ConvertToDecimal(input));
    }

    static int ConvertToDecimal(string input)
    {
        int number = 0;
        int power = 0;
        input = input.ToUpper();

        for (int bit = input.Length - 1; bit >= 0; bit--)
        {
            switch (input[bit].ToString())
            {
                case "A":
                    number += 10 * (int)Math.Pow(NumSystem, power);
                    break;
                case "B":
                    number += 11 * (int)Math.Pow(NumSystem, power);
                    break;
                case "C":
                    number += 12 * (int)Math.Pow(NumSystem, power);
                    break;
                case "D":
                    number += 13 * (int)Math.Pow(NumSystem, power);
                    break;
                case "E":
                    number += 14 * (int)Math.Pow(NumSystem, power);
                    break;
                case "F":
                    number += 15 * (int)Math.Pow(NumSystem, power);
                    break;
                default:
                    int currBit = int.Parse(input[bit].ToString());
                    number += currBit * (int)Math.Pow(NumSystem, power);
                    break;
            }
            power++;
        }

        return number;
    }
}