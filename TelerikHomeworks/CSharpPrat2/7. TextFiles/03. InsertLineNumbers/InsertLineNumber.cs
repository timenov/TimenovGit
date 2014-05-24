//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;
using System.Text;

class InsertLineNumber
{
    static void Main(string[] args)
    {
        try
        {
            Encoding cyrillic = Encoding.GetEncoding("windows-1251");
            StreamReader input = new StreamReader(@"../../InsertLineNumber.cs", cyrillic);
            StreamWriter output = new StreamWriter(@"../../AddedLines.txt", false, cyrillic);

            using (output)
            {
                using (input)
                {
                    string line;
                    int lineNumber = 1;
                    while ((line = input.ReadLine()) != null)
                    {
                        output.WriteLine("Line {0}: {1}", lineNumber, line);
                        lineNumber++;
                    }
                }
            }
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        Console.WriteLine("Job is done.");
    }
}