//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).
using System;
using System.Text;

class Convertion
{
    static long ToDecimal(string input, int numSys)
    {
        long number = 0;
        int power = 0;

        for (int bit = input.Length - 1; bit >= 0; bit--)
        {
            int currBit = 0;
            switch (input[bit].ToString())
            {
                case "A":
                    currBit = 10;
                    break;
                case "B":
                    currBit = 11;
                    break;
                case "C":
                    currBit = 12;
                    break;
                case "D":
                    currBit = 13;
                    break;
                case "E":
                    currBit = 14;
                    break;
                case "F":
                    currBit = 15;
                    break;
                default:
                    currBit = int.Parse(input[bit].ToString());
                    break;
            }
            number += currBit * (int)Math.Pow(numSys, power);
            power++;
        }

        return number;
    }

    static string FromDecimal(long number, int numSys)
    {
        StringBuilder reversedBitsString = new StringBuilder();
        
        while (number > 0)
        {
            string digit = string.Empty;
            switch (number % numSys)
            {
                case 10:
                    digit = "A";
                    break;
                case 11:
                    digit = "B";
                    break;
                case 12:
                    digit = "C";
                    break;
                case 13:
                    digit = "D";
                    break;
                case 14:
                    digit = "E";
                    break;
                case 15:
                    digit = "F";
                    break;
                default:
                    digit = (number % numSys).ToString();
                    break;
            }
            reversedBitsString.Append(digit);
            number /= numSys;
        }

        char[] reversedBits = reversedBitsString.ToString().ToCharArray();
        Array.Reverse(reversedBits);

        return string.Join("", reversedBits);
    }

    static string Convertor(string str, int inNS, int outNS)
    {
        if (inNS == outNS)
        {
            return str;
        }
        else
        {
            return FromDecimal(ToDecimal(str, inNS), outNS);
        }
    }
    static void Main()
    {
        Console.Write("enter input numeral system: ");
        int inputNS = int.Parse(Console.ReadLine());
        Console.Write("enter number: ");
        string input = Console.ReadLine().ToUpper();
        Console.Write("enter output numeral system: ");
        int outputNS = int.Parse(Console.ReadLine());
        Console.WriteLine(Convertor(input, inputNS, outputNS));
    }
}