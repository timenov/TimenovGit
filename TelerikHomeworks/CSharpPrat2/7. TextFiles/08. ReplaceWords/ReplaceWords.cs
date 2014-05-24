//Modify the solution of the previous problem to replace only whole words (not substrings).
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceWords
{
    static Encoding cyrillic = Encoding.GetEncoding("windows-1251");

    static void Main()
    {
        try
        {
            using (StreamWriter output = new StreamWriter(@"../../FixedFile.txt", true, cyrillic))
            {
                using (StreamReader input = new StreamReader(@"../../InputFile.txt", cyrillic))
                {
                    string pattern = @"\bstart\b";
                    while (!input.EndOfStream)
                    {
                        string line = input.ReadLine();
                        line = Regex.Replace(line, pattern, "finish");
                        output.WriteLine(line);
                    }
                }
            }
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}