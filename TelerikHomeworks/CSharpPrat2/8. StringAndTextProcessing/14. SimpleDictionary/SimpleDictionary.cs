//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary. 
using System;
using System.Text.RegularExpressions;

class SimpleDictionary
{
    static string dictionary = @".NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes";

    static void Main()
    {
        Console.Write("enter word: ");
        string word = Console.ReadLine() + ".+";

        Console.WriteLine(Regex.Match(dictionary, word, RegexOptions.IgnoreCase));
    }
}