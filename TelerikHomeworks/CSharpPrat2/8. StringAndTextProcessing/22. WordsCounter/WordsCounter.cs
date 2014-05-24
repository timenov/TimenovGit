//Write a program that reads a string from the console and lists all different words in the string
//along with information how many times each word is found.
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class WordsCounter
{
    static void Main()
    {
        Console.WriteLine("enter some text: ");
        string text = Console.ReadLine().ToLower();

        Dictionary<string, int> counter = new Dictionary<string, int>();

        foreach (Match word in Regex.Matches(text, @"\w+"))
        {
            if (counter.ContainsKey(word.Value))
                counter[word.Value]++;
            else
                counter.Add(word.Value, 1);
        }

        foreach (KeyValuePair<string, int> entry in counter)
        {
            Console.WriteLine("word: {0} - {1} time(s)", entry.Key, entry.Value);
        }
    }
}