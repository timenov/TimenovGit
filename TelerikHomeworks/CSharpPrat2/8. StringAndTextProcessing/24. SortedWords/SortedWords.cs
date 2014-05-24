//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
using System;

class SortedWords
{
    static void Main()
    {
        string text = "ma mi mo me";
        text = text.ToLower();
        string[] words = text.Split(' ');
        Array.Sort(words);

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}