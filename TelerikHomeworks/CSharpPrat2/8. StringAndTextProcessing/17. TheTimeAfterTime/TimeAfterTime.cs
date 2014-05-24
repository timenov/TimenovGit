//Write a program that reads a date and time given in the format:
//day.month.year hour:minute:second and
//prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
using System;
using System.Globalization;
using System.Text;

class TimeAfterTime
{
    static void Main()
    {
        Console.Write("Enter date and time (in format dd.mm.yyyy hh:mm:ss): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        date = date.AddHours(6.5);

        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("{0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
    }
}