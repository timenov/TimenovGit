//Write a method that returns the last digit of given integer as an English word.
using System;

class LastDigitMethod
{
    static string LastDigit(int number)
    {
        byte digit = (byte)(number % 10);
        string digitName = "";
        switch (digit)
        {
            case 0: digitName = "zero";
                break;
            case 1: digitName =  "one";
                break;
            case 2: digitName =  "two";
                break;
            case 3: digitName =  "three";
                break;
            case 4: digitName =  "four";
                break;
            case 5: digitName =  "five";
                break;
            case 6: digitName =  "six";
                break;
            case 7: digitName =  "seven";
                break;
            case 8: digitName =  "eight";
                break;
            case 9: digitName =  "nine";
                break;
        }
        return digitName;
    }

    static void Main()
    {
        Console.Write("enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigit(number));
    }
}