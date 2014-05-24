// Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
using System;

class ExchangeInts
{
    static void Main()
    {
        Console.Write("Enter first int: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second int: ");
        int second = int.Parse(Console.ReadLine());

        Console.WriteLine("first int is {0}\nsecond int is {1}", first, second);

        Console.WriteLine("\nAfter \"if\" statement...\n");
        if (first > second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
        Console.WriteLine("first int is {0}\nsecond int is {1}", first, second);
    }
}