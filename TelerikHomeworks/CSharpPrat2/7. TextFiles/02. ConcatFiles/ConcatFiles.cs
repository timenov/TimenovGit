//Write a program that concatenates two text files into another text file.
using System;
using System.Text;
using System.IO;

class ConcatFiles
{
    static Encoding cyrillic = Encoding.GetEncoding("windows-1251");
    static void Main()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(@"../../ConcatFile.txt", true, cyrillic))
            {
                for (int i = 0; i < 2; i++)
                {
                    WriteToFile(writer, @"../../ConcatFiles.cs");
                }
            }
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        Console.WriteLine("Concatenation is done.");
    }
    static void WriteToFile(StreamWriter output, string input)
    {
        using (StreamReader reader = new StreamReader(input, cyrillic))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                output.WriteLine(line);
            }
        }
    }
}