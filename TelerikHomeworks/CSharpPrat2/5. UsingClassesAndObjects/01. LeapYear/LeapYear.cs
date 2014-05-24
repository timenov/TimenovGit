//Write a program that reads a year from the console and checks whether it is a leap.
using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("enter year: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("the year is leap: {0}", DateTime.IsLeapYear(year));
    }
}