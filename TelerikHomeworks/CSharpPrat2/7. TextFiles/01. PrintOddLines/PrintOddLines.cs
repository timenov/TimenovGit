//Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.Text;
using System.IO;

class PrintOddLines
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader(@"../../PrintOddLines.cs", Encoding.GetEncoding("windows-1251"));
            using (reader)
            {
                int lineNumber = 1;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (lineNumber % 2 == 1)
                    {
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    }
                    lineNumber++;
                }
            }
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}