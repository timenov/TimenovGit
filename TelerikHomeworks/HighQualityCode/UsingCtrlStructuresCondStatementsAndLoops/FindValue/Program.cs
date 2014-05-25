using System;

class Program
{
    public static bool Contains<T>(T[] array, T expectedValue)
    {
        for (int i = 1; i < 100; i += 10)
        {
            if (array[i].Equals(expectedValue))
            {
                return true;
            }
        }

        return false;
    }
        
    public static void Main()
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5 };

        if (Contains(arr, 4))
        {
            Console.WriteLine("Value Found");
        }
    }
}
