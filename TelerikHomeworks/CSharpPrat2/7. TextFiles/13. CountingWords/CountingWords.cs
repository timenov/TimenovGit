//Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.

using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class CountingWords
{
    static Encoding cyrillic = Encoding.GetEncoding("windows-1251");

    static void Main()
    {
        try
        {
            StreamReader reader;
            StringBuilder content = new StringBuilder();
            string[] words = null;
            //read words from file
            using (reader = new StreamReader(@"../../words.txt", cyrillic))
            {
                while (!reader.EndOfStream)
                {
                    content.AppendLine(reader.ReadLine());
                }
                words = Regex.Split(content.ToString(), @"\s+");
            }
            //create pattern with words in file
            StringBuilder temp = new StringBuilder();
            foreach (string word in words)
            {
                if (word.Length > 0)
                    temp.Append(word + "|");
            }
            temp.Append("\b\0\b");
            string pattern = @"\b(" + temp + @")\b";

            Regex regex = new Regex(pattern);
            using (reader = new StreamReader(@"../../test.txt", cyrillic))
            {
                content.Clear();
                while (!reader.EndOfStream)
                {
                    content.Append(reader.ReadLine());
                }
            }
            Match match = regex.Match(content.ToString());
            
            Dictionary<string, int> pairs = new Dictionary<string, int>();
            while (match.Success)
            {
                string word = match.ToString();
                if (pairs.ContainsKey(word))
                    pairs[word]++;
                else
                    pairs.Add(word, 1);
                match = match.NextMatch();
            }

            using (StreamWriter output = new StreamWriter(@"../../result.txt", false, cyrillic))
            {
                foreach (var pair in pairs)
                {
                    output.WriteLine("word: {0} contained {1}", pair.Key, pair.Value);
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