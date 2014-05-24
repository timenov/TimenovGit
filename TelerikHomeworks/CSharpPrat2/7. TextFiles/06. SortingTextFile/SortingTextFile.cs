//Write a program that reads a text file containing a list of strings,
//sorts them and saves them to another text file. 
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

class SortingTextFile
{
    static void Main()
    {
        try
        {
            List<string> lines = new List<string>();
            Encoding cyrillic = Encoding.GetEncoding("windows-1251");
            using (StreamReader input = new StreamReader(@"../../Unsorted.txt", cyrillic))
            {
                while (!input.EndOfStream)
                {
                    lines.Add(input.ReadLine());
                }
            }

            lines.Sort();

            using (StreamWriter output = new StreamWriter(@"../../Sorted.txt", false, cyrillic))
            {
                foreach (string line in lines)
                {
                    output.WriteLine(line);
                }
            }
            Console.WriteLine("Done.");
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}