//Write a program to convert hexadecimal numbers to binary numbers (directly).
using System;
using System.Collections.Generic;
using System.Text;

class HexToBinary
{
    static string TrimZeroes(string str)
    {
        // trim first zeroes - example: 0110 -> 110
        while (str[0].Equals('0'))
        {
            str = str.Remove(0, 1);
        }
        return str;
    }
    static string HexToBin(string hex)
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        for (int i = 0; i < 16; i++)
        {
            dictionary.Add(Convert.ToString(i, 16), Convert.ToString(i, 2).PadLeft(4, '0'));
        }

        StringBuilder number = new StringBuilder();
        for (int i = 0; i < hex.Length; i++)
        {
            number.Append(dictionary[hex[i].ToString()]);
        };
        return TrimZeroes(number.ToString());
    }
    static void Main()
    {
        Console.Write("enter hexadecimal number: ");
        string input = Console.ReadLine();
        Console.WriteLine("to binary: {0}", HexToBin(input.ToLower()));
    }
}