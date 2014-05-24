//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks. 
using System;
using System.Text.RegularExpressions;

class ForbiddenWords
{
    static void Main()
    {
        Console.WriteLine("enter some text or \"Enter\" for default:");
        string text;
        if ((text = Console.ReadLine()).Length == 0)
        {
            text = @"Microsoft announced its next generation PHP compiler today.
It is based on .NET Framework 4.0
and is implemented as a dynamic language in CLR.";
        }

        Console.WriteLine("enter forbidden words separated with non-letter or \"Enter\" for default: ");
        string forbWords;
        if ((forbWords = Console.ReadLine()).Length == 0)
        {
            forbWords  = "PHP, CLR, Microsoft";
        }
        Console.WriteLine("text:\n{0}\n\nforbidden words: {1}", text, forbWords);
        string[] fWords = Regex.Split(forbWords, @"\W+");

        foreach (string word in fWords)
        {
            text = Regex.Replace(text, word, new string('*', word.Length), RegexOptions.IgnoreCase);
        }

        Console.WriteLine("\n" + text);
    }
}