//Write a program that compares two text files line by line and
//prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.
using System;
using System.IO;
using System.Text;

class CompareFiles
{
    static void Main()
    {
        try
        {
            Encoding cyrillic = Encoding.GetEncoding("windows-1251");
            StreamReader[] input = { new StreamReader(@"../../File1.txt", cyrillic), new StreamReader(@"../../File2.txt", cyrillic) };
            string firstFileLine, secondFileLine;
            int equal = 0, notEqual = 0;
            using (input[0])
            {
                using (input[1])
                {
                    while ((firstFileLine = input[0].ReadLine()) != null && (secondFileLine = input[1].ReadLine()) != null)
                    {
                        if (firstFileLine.Equals(secondFileLine))
                            equal++;
                        else
                            notEqual++;
                    }
                }
            }
            Console.WriteLine("The two files have {0} equal, and {1} not equal lines.", equal, notEqual);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}