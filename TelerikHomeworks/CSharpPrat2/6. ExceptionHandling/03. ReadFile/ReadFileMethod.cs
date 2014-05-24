//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
//reads its contents and prints it on the console.
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

class ReadFileMethod
{
    static void ReadFile(string filePath)
    {
        try
        {
            string output = File.ReadAllText(filePath);
            Console.WriteLine(output);
        }
        catch (SystemException se)
        {
            Console.WriteLine(se.Message);
        }
    }
    static void Main()
    {
        Console.Write("enter path to text file: ");
        string filePath = Console.ReadLine();
        ReadFile(filePath);
    }
}