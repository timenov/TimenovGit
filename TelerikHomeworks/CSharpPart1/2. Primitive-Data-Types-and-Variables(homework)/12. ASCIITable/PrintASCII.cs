//Write a program that prints the entire ASCII table of characters on the console.

using System;
using System.Text;

class PrintASCII
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        for (byte i = 0; i < 32; i++)
        {
            Console.WriteLine("{0} -> {1} \t{2} -> {3} \t{4} -> {5} \t{6} -> {7}",
                i, (char)i, i + 32, (char)(i + 32), i + 64, (char)(i + 64), i + 96, (char)(i + 96));
        }
    }
}
