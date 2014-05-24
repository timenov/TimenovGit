//Write a program to check if in a given expression the brackets are put correctly.
using System;

class CheckBrackets
{
    static void Main()
    {
        Console.Write("input expression: ");
        string input = Console.ReadLine();

        int brackets = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Equals('('))
                brackets++;
            else if (input[i].Equals(')'))
                brackets--;

            if (brackets < 0)
                break;
        }

        if (brackets == 0)
            Console.WriteLine("expression is correct");
        else
            Console.WriteLine("expression is incorrect");
    }
}