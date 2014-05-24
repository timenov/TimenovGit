//Write a program that reads a string from the console and prints all different letters in the string
//along with information how many times each letter is found. 
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class LetterCounter
{
    static void Main()
    {
        Console.Write("enter some text: ");
        string text = Console.ReadLine().ToLower();

        Dictionary<string, int> counter = new Dictionary<string, int>();
        foreach (Match match in Regex.Matches(text, @"[a-z]"))
        {
            if (counter.ContainsKey(match.ToString()))
                counter[match.ToString()]++;
            else
                counter.Add(match.ToString(), 1);
        }

        foreach (KeyValuePair<string, int> entry in counter)
        {
            Console.WriteLine("letter: '{0}' - {1} time(s)", entry.Key, entry.Value);
        }
    }
}