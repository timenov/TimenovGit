//Write a program that reverses the words in given sentence.
using System;
using System.Text.RegularExpressions;

class ReverseWords
{
    static void Main()
    {
        Console.WriteLine("enter some text: ");
        string text = Console.ReadLine();
        string pattern = @"(\,\s)?\w+(([+#])+)?";
        MatchCollection matches = Regex.Matches(text, pattern);

        for (int i = matches.Count - 1; i >= 0; i--)
        {
            char a = matches[i].ToString()[0];
            if (a.Equals(','))
                Console.Write("\b{0} ", matches[i]);
            else
                Console.Write("{0} ", matches[i]);
        }
        Console.WriteLine("\b" + Regex.Match(text, @"\W+$"));
    }
}