//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception. 
using System;

class ReadNumberMethod
{
    static int ReadNumber(int start, int end)
    {
        Console.Write("Enter number between {0} and {1}: ", start, end);
        int number = int.Parse(Console.ReadLine());
        if (number <= start || number >= end)
        {
            throw new ArgumentOutOfRangeException();
        }
        return number;
    }

    static void Main()
    {
        int min = 1;
        try
        {
            for (int i = 0; i < 10; i++)
            {   
                min = ReadNumber(min, 100);
            }
        }
        catch (SystemException se)
        {
            Console.WriteLine(se.Message);
        }
    }
}