//Write a program for extracting all email addresses from given text.
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
using System;
using System.Text.RegularExpressions;

class ExtractEMails
{
    static void Main()
    {
        Console.WriteLine("Enter email's list or press \"Enter\" for default: ");
        string list;
        if ((list = Console.ReadLine()).Length == 0)
        {
            list = "a@a.bg zuzi@kaval.bg/ ciki@duduk.net, bob@mail.bg: fn12345@fmi.uni-sofia.bg\nmente@eu.int, gero@dir.bg, tikvenik_13@abv.bg nonemailadress.com, nonemail@ff";
        }
        Console.WriteLine("\n" + list + "\n");

        Match match = Regex.Match(list, @"([\w\.-]+)@([a-z]+([\.\-]{1}[a-z]+)?)(\.)([a-z]{2,4}(\.[a-z]{2,4})?)", RegexOptions.IgnoreCase);
        while (match.Success)
        {
            Console.WriteLine(match);
            match = match.NextMatch();
        }
    }
}