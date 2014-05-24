//Write a program that extracts from a given text all palindromes.
using System;
using System.Text.RegularExpressions;

class ExtractPalindromes
{
    static void Main()
    {
        Console.WriteLine("enter words or press \"Enter\" for default: ");
        string list;
        if ((list = Console.ReadLine()).Length == 0)
        {
            list = "ABBA, lamal   back front exe  i";
        }
        Console.WriteLine(list + "\n");

        foreach (Match match in Regex.Matches(list, @"\w+"))
        {
            if (IsPalindrom(match.Value))
            {
                Console.WriteLine(match);
            }
        }
    }
    static bool IsPalindrom(string word)
    {
        word = word.ToLower();
        int front = 0;
        int back = word.Length - 1;
        bool isPalindrom = true;

        while (front < back)
        {
            if (!word[front].Equals(word[back]))
            {
                isPalindrom = false;
                break;
            }
            front++;
            back--;
        }
        return isPalindrom;
    }
}