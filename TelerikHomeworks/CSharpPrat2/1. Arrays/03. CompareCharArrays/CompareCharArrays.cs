//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter arrays length: ");
        int arrLength = int.Parse(Console.ReadLine());
        char[] firstArr = new char[arrLength];
        char[] secondArr = new char[arrLength];

        Console.WriteLine("\nEnter first array elements:");
        for (int i = 0; i < firstArr.Length; i++)
        {
            firstArr[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nEnter second array elements:");
        for (int i = 0; i < secondArr.Length; i++)
        {
            secondArr[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        for (int i = 0; i < firstArr.Length; i++)
        {
            if (firstArr[i] > secondArr[i])
            {
                Console.WriteLine("{0} is then {1}", firstArr[i], secondArr[i]);
            }
            else if (firstArr[i] < secondArr[i])
            {
                Console.WriteLine("{0} is before {1}", firstArr[i], secondArr[i]);
            }
            else
            {
                Console.WriteLine("{0} is equal with {1}", firstArr[i], secondArr[i]);
            }
        }
    }
}