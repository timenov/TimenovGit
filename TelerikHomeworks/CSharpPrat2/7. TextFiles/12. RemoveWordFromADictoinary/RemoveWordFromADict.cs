//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class RemoveWordFromADict
{
    static Encoding cyrillic = Encoding.GetEncoding("windows-1251");

    static void Main()
    {
        try
        {
            StreamReader reader;
            string[] words;
            StringBuilder content = new StringBuilder();
            using (reader = new StreamReader(@"../../words.txt", cyrillic))
            {
                while (!reader.EndOfStream)
                {
                    content.AppendLine(reader.ReadLine());
                }
                words = Regex.Split(content.ToString(), @"\s");
            }
            string pattern = "";
            foreach (string word in words)
            {
                if (!word.Equals(""))
                {
                    pattern = pattern + word + "|";   
                }
            }
            pattern = pattern + "\b\0\b";
            pattern = @"\b(" + pattern + @")\b";

            Regex regex = new Regex(@pattern);
            content.Clear();
            using (reader = new StreamReader(@"../../Text.txt", cyrillic))
            {
                while (!reader.EndOfStream)
                {
                    content.AppendLine(reader.ReadLine());
                }
            }

            using (StreamWriter output = new StreamWriter(@"../../Text.txt", false, cyrillic))
            {
                output.Write(regex.Replace(content.ToString(), ""));
            }

            Console.WriteLine("Done.");
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}