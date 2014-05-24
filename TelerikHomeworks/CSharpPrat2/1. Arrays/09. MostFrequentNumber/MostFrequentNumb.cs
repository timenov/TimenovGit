//Write a program that finds the most frequent number in an array.

using System;

class MostFrequentNumb
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int[] array = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] data = new int[2];

        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            count = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                }
            }
            if (count > data[1])
            {
                data[0] = array[i];
                data[1] = count;
            }
        }
        Console.WriteLine("{0}({1} times)", data[0], data[1]);
    }
}