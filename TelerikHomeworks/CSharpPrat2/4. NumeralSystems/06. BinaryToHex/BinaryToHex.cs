//Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;
using System.Collections.Generic;
using System.Text;

class BinaryToHex
{
    static string Reverse(string str)
    {
        char[] chars = str.ToCharArray();
        for (int i = 0; i < chars.Length/2; i++)
        {
            char temp = chars[i];
            chars[i] = chars[chars.Length - 1 - i];
            chars[chars.Length - 1 - i] = temp;
        }
        str = new String(chars);
        return str;
    }
    static string BinToHex(string str)
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        for (int i = 0; i < 16; i++)
        {
            dictionary.Add(Convert.ToString(i, 2).PadLeft(4, '0'), Convert.ToString(i, 16));
        }
        if (str.Length % 4 != 0)
        {
            int padLeftCount = str.Length + (4 - (str.Length % 4));
            str = str.PadLeft(padLeftCount, '0');    
        }
        StringBuilder number = new StringBuilder();
        int digit = str.Length - 4;
        while (str.Length > 0)
        {
            string temp = str.Substring(digit, 4);
            number.Append(dictionary[temp]);
            str = str.Remove(digit);
            digit -= 4;
        }
        return Reverse(number.ToString().ToUpper());
    }
    static void Main()
    {
        Console.Write("enter binary number: ");
        string input = Console.ReadLine();
        Console.WriteLine("to hexadecimal: {0}",BinToHex(input));
    }
}