// Write a program that reads two positive integer numbers and prints how many numbers p exist between them
// such that the reminder of the division by 5 is 0 (inclusive).

using System;

class HowNumbersExist
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());

        int p = 0;
        for (int i = first; i <= second; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }

        Console.WriteLine("There is {0} numbers between {1} and {2} wich are divided by 5.", p, first, second);
    }
}
