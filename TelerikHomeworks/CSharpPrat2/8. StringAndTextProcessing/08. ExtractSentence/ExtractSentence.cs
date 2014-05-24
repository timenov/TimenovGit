//Write a program that extracts from a given text all sentences containing given word.
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractSentence
{
    static void Main()
    {
        string text = @"We are living in a yellow submarine. 
We don't have anything else. Inside the submarine is very tight. 
So we are drinking all the day. We will move out of it in 5 days.";

        string[] sentences = Regex.Split(text, @"[\!\.\?]\s");

        foreach (string sentence in sentences)
        {
            if (Regex.IsMatch(sentence, @"\bin\b"))
            {
                Console.WriteLine(sentence);
            }
        }
    }
}