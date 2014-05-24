// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DivideByFiveAndSeven
{
    static void Main()
    {
        Console.Write("Write number between -2^31 and 2^31: ");

        int numb = int.Parse(Console.ReadLine());

        bool isDivide = (numb % 5 == 0) && (numb % 7 == 0);

        Console.WriteLine("Is number divided by 5 and 7 at the same time: {0}", isDivide);
    }
}