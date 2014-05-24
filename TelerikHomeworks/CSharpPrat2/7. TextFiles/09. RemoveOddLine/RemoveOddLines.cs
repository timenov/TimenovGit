//Write a program that deletes from given text file all odd lines. The result should be in the same file.
using System;
using System.Text;
using System.IO;

class RemoveOddLines
{
    static Encoding cyrillic = Encoding.GetEncoding("windows-1251");

    static void Main()
    {
        try
        {
            string filePath = @"../../TextFile.txt";
            StringBuilder newContent = new StringBuilder();
            using (StreamReader input = new StreamReader(filePath, cyrillic))
            {
                int line = 1;
                while (!input.EndOfStream)
                {
                    if (line % 2 == 0)
                        newContent.AppendLine(input.ReadLine());
                    else
                        input.ReadLine();
                    line++;
                }
            }

            using (StreamWriter output = new StreamWriter(filePath, false, cyrillic))
            {
                output.Write(newContent);
            }
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}