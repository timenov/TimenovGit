//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
using System;
using System.IO;
using System.Text;

class ReplaceOccurrences
{
    static Encoding cyrillic = Encoding.GetEncoding("windows-1251");

    static void Main()
    {
        try
        {
            using (StreamWriter output = new StreamWriter("../../FixedFile.txt", true, cyrillic))
            {
                using (StreamReader input = new StreamReader(@"../../InputFile.txt", cyrillic))
                {
                    while (!input.EndOfStream)
                    {
                        string line = input.ReadLine();
                        line = line.Replace("start", "finish");
                        output.WriteLine(line);
                    }
                }
            }
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}