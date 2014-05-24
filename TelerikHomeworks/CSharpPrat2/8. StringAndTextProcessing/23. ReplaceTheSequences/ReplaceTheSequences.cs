using System;
using System.Text.RegularExpressions;

class ReplaceTheSequences
{
    static void Main()
    {
        string str = "aaaaabbbbbcdddeeeedssaa";

        Console.WriteLine(Regex.Replace(str, @"(\w)\1+", "$1"));
    }
}