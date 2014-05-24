//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
using System;

class SplitAndSum
{
    static void Main()
    {
        Console.WriteLine("enter some numbers separated by spaces:");
        string str = Console.ReadLine();
        string[] splitStr = str.Split(' ');

        int[] numbers = new int[splitStr.Length];
        for (int i = 0; i < splitStr.Length; i++)
        {
            numbers[i] = int.Parse(splitStr[i]);
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine("the of numbers is {0}", sum);
    }
}