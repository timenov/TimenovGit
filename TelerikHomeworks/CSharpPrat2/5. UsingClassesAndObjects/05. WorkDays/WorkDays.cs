//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
using System;

class WorkDays
{
    static DateTime[] holidays = { new DateTime(2013, 9, 6), new DateTime(2013, 9, 22), new DateTime(2013, 12, 24),
                                     new DateTime(2013, 12, 25), new DateTime(2013, 12, 26), new DateTime(2013, 12, 31),
                                     new DateTime(2014, 1, 1), new DateTime(2014, 3, 3), new DateTime(2014, 4, 16),
                                     new DateTime(2014, 4, 17), new DateTime(2014, 4, 18), new DateTime(2014, 5, 1),
                                     new DateTime(2014, 5, 6), new DateTime(2014, 5, 24) };

    static void Main()
    {
        DateTime startDate = DateTime.Today;
        DateTime endDate = new DateTime(2013, 10, 13);
        
        Console.WriteLine("{0} work days", CalcWorkDays(startDate, endDate));
    }
    static bool IsNotHoliday(DateTime day)
    {
        bool isNotHoliday = true;
        foreach (var holiday in holidays)
        {
            if (holiday == day)
            {
                isNotHoliday = false;
            }
        }
        return isNotHoliday;
    }
    static int CalcWorkDays(DateTime start, DateTime end)
    {
        int days = 0;

        while (start <= end)
        {
            if (start.DayOfWeek != DayOfWeek.Saturday && start.DayOfWeek != DayOfWeek.Sunday && IsNotHoliday(start))
            {
                days++;
            }
            start = start.AddDays(1);
        }
        return days;
    }
}