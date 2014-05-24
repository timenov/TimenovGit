//You are given an array of strings.
//Write a method that sorts the array by the length of its elements (the number of characters composing them).
using System;

class SortStringArray
{
    static void Main()
    {
        string[] array = { "manamanaa", "tumbuktu", "shupiluliuma", "azare" };

        int smallestIndex = 0;
        int smallestLength = array[smallestIndex].Length;
        int startIndex = 0;
        while (startIndex < array.Length)
        {
            for (int i = startIndex; i < array.Length; i++)
            {
                int temp = array[i].Length;
                if (temp < smallestLength)
                {
                    smallestIndex = i;
                    smallestLength = temp;
                }
            }
            string tempString = array[startIndex];
            array[startIndex] = array[smallestIndex];
            array[smallestIndex] = tempString;
            startIndex++;
            smallestLength = array[array.Length - 1].Length;
            smallestIndex = array.Length - 1;
        }

        foreach (string word in array)
        {
            Console.WriteLine(word);
        }
    }
}