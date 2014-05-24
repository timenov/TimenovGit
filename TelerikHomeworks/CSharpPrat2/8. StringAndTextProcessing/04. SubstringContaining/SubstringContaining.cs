//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
using System;
using System.Text.RegularExpressions;

class SubstringContaining
{
    static void Main()
    {
        string text = @"We are living in an yellow submarine. We don't have anything else. 
Inside the submarine is very tight. So we are drinking all the day.
We will move out of it in 5 days.";
        Console.WriteLine("Text is: \n{0}", text);
        Console.Write("\ninput substring you want to search: ");
        string substr = Console.ReadLine();
        Regex regex = new Regex(substr, RegexOptions.IgnoreCase);

        Match match = regex.Match(text);
        int matches = 0;
        while (match.Success)
        {
            matches++;
            match = match.NextMatch();
        }

        Console.WriteLine("The result is: {0}", matches);
    }
}