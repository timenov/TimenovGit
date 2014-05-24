//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.
//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.).
using System;
using System.Collections.Generic;
using System.Text;

class GenericMethods
{
    static T Min<T>(T[] array)
    {
        dynamic min = array[0];
        for (int index = 1; index < array.Length; index++) //starts from second element, because min = first element
        {
            if (array[index] < min)
            {
                min = array[index];
            }
        }
        return min;
    }
    static T Max<T>(T[] array)
    {
        dynamic max = array[0];
        for (int index = 1; index < array.Length; index++) //starts from second element because max = first element
        {
            if (array[index] > max)
            {
                max = array[index];
            }
        }
        return max;
    }
    static T Average<T>(T[] array)
    {
        dynamic average = 0;
        for (int index = 0; index < array.Length; index++)
        {
            average += array[index];
        }
        average /= array.Length;
        return average;
    }
    static T Sum<T>(T[] array)
    {
        dynamic sum = 0;
        for (int index = 0; index < array.Length; index++)
        {
            sum += array[index];
        }
        return sum;
    }
    static T Product<T>(T[] array)
    {
        dynamic product = 1;
        for (int index = 0; index < array.Length; index++)
        {
            product *= array[index];
        }
        return product;
    }
    static void Main()
    {
        byte[] byteArr = new byte[] { 4, 2, 6, 1, 8, 5, 9 };
        int[] intArr = new int[] { 1, 9, 7, 6, 3, 2, };
        float[] floatArr = new float[] { 0.1f, 2.0f, 0.6f, 0.5425f, 1.6289f };
        double[] doubleArr = new double[] { 4.17589542, 0.5417964, 134.2356689987, 3432.4353212 };
        decimal[] decimalArr = new decimal[] { 0.443341245m, 1.2334321m, 3.45312389m, 8.0000012m };

        Console.WriteLine("min of bytes {0}", Min(byteArr));
        Console.WriteLine("max of ints {0}", Max(intArr));
        Console.WriteLine("average of floats {0}", Average(floatArr));
        Console.WriteLine("sum of doubles {0}", Sum(doubleArr));
        Console.WriteLine("product of decimals {0}", Product(decimalArr));
    }
}