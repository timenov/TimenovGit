//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
using System;

class DateDistance
{
    static void Main()
    {
        Console.Write("enter the first date: ");
        DateTime first = DateTime.Parse(Console.ReadLine());
        Console.Write("enter the second date: ");
        DateTime second = DateTime.Parse(Console.ReadLine());
        if (first.Year > second.Year)
            second = second.AddYears(first.Year % second.Year);
        Console.WriteLine("Distance: {0}", (second - first).TotalDays);
    }
}