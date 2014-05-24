//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters. 
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key,
//the second – with the second, etc. When the last key character is reached, the next is the first.
using System;
using System.Text;
using System.Collections.Generic;

class EDString
{
    static void Main()
    {
        Console.Write("enter string to encode: ");
        string input = Console.ReadLine();
        Console.Write("enter key: ");
        string key = Console.ReadLine();

        string encrypted = Encrypt(input, key);
        Console.WriteLine("Encrypted: \n{0}", encrypted);
        Console.WriteLine("Decrypted: \n{0}", Decrypt(encrypted, key));
    }

    static string Encrypt(string input, string key)
    {
        int keyIndex = 0;
        int inputIndex = 0;
        StringBuilder output = new StringBuilder(input.Length);
        while (true)
        {
            output.Append((char)(input[inputIndex] ^ key[keyIndex]));
            if (keyIndex == key.Length - 1)
                keyIndex = 0;
            else
                keyIndex++;

            if (inputIndex == input.Length - 1)
                break;
            else
                inputIndex++;
        }
        return output.ToString();
    }
    static string Decrypt(string input, string key)
    {
        return Encrypt(input, key);
    }
}