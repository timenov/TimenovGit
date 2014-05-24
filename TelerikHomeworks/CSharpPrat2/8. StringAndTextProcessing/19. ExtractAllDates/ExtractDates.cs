//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.
using System;
using System.Text.RegularExpressions;
using System.Globalization;

class ExtractDates
{
    static void Main()
    {
        string list = "22.13.2222  22.12.2005 02.09.2013 3.3.2003 43.3.2005 00.00.2004";
        string pattern = @"((\b0?[1-9])|([1-3]\d))\.((0?[1-9])|(1[0-2]))\.(\d{4})";

        Match match = Regex.Match(list, pattern);
        DateTime date = DateTime.Today;
        while (match.Success)
        {
            DateTime.TryParse(match.ToString(), out date);
            Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            match = match.NextMatch();
        }
    }
}