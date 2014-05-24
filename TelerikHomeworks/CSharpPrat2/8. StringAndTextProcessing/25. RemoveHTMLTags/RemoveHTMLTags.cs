//Write a program that extracts from given HTML file its title (if available), and 
//its body text without the HTML tags. 
using System;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;

class RemoveHTMLTags
{
    static void Main()
    {
        string html;
        using (StreamReader input = new StreamReader(@"../../test.txt"))
        {
            html = input.ReadToEnd();
        }

        bool haveTitle = Regex.IsMatch(html, @"<title>", RegexOptions.IgnoreCase);

        html = Regex.Replace(html, @"(<.*?\s?.*?>)|(\w+)", "$2"); //remove html tags

        foreach (Match item in Regex.Matches(html, @"\b.+[\n\r]"))
        {
            string s = item.Value;
            if (haveTitle)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(item.Value);
                haveTitle = false;
                Console.ResetColor();
            }
            else
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}