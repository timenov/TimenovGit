//Write a program that deletes from a text file all words that start with the prefix "test".
//Words contain only the symbols 0...9, a...z, A…Z, _.
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

class RemoveWord
{
    static void Main()
    {
        try
        {
            StringBuilder newContent = new StringBuilder();
            string filePath = @"../../Text.txt";
            using (StreamReader input = new StreamReader(filePath))
            {
                Regex regex = new Regex(@"\btest\w+");
                while (!input.EndOfStream)
                {
                    string line = input.ReadLine();
                    newContent.AppendLine(regex.Replace(line, ""));
                }
            }

            using (StreamWriter output = new StreamWriter(filePath, false))
            {
                output.Write(newContent);
            }

            Console.WriteLine("Done.");
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}