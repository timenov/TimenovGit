//Write a program that extracts from given XML file all the text without the tags. 
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ExtractTextFromXML
{
    static void Main()
    {
        try
        {
            StringBuilder fileContent = new StringBuilder();
            Regex regex = new Regex(@"<.+?>");
            using (StreamReader input = new StreamReader(@"../../Library.xml"))
            {
                while (!input.EndOfStream)
                {
                    fileContent.AppendLine(input.ReadLine());
                }
            }
            using (StreamWriter output = new StreamWriter(@"../../OnlyText.txt", false))
            {
                output.Write(regex.Replace(fileContent.ToString(), ""));
            }

            Console.WriteLine("Done.");
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}