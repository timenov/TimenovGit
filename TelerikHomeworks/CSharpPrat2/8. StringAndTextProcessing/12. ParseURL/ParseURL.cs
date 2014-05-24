//Write a program that parses an URL address given in the format:
//and extracts from it the [protocol], [server] and [resource] elements.
//For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"
using System;

class ParseURL
{
    static void Main()
    {
        Console.Write("enter URL address: ");
        string url = Console.ReadLine();
        Console.WriteLine("[protocol] = \"{0}\"", ExtractProtocol(url));
        Console.WriteLine("[server] = \"{0}\"", ExtractServer(url));
        Console.WriteLine("[resource] = \"{0}\"", ExtractResource(url));
    }
    static string ExtractProtocol(string url)
    {
        return url.Substring(0, url.IndexOf(':'));
    }
    static string ExtractServer(string url)
    {
        int startIndex = url.IndexOf(@"//") + 2;
        int length = url.IndexOf('/', startIndex) - startIndex;
        return url.Substring(startIndex, length);
    }
    static string ExtractResource(string url)
    {
        int startIndex = 0;
        for (int i = 0; i < 3; i++)
        {
            startIndex = url.IndexOf('/', startIndex + 1);
        }
        return url.Substring(startIndex);
    }
}