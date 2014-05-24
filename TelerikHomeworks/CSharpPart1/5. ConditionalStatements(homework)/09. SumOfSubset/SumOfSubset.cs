using System;

class SumOfSubset
{
    static int[] numbers;
    static int combinations;
    static int[] readyComb;

    static void Main()
    {
        Console.Write("Enter multiplicity size: ");
        int size = int.Parse(Console.ReadLine());
        numbers = new int[size];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("n{0} = ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        for (int i = 2; i <= numbers.Length; i++)
        {
            combinations = i;
            readyComb = new int[i];
            recursion(0, 0);
        }
    }

    static void printComb()
    {
        if (calculate(readyComb) == 0)
        {
            foreach (var combos in readyComb)
            {
                Console.Write("{0} ", combos);
            }
            Console.WriteLine();
        }
    }
    static int calculate(int[] array)
    {
        int result = 0;
        foreach (var n in array)
        {
            result += n;
        }
        return result;
    }

    static void recursion(int indexReadyComb, int indexStrs)
    {
        if (indexReadyComb == combinations)
        {
            printComb();
            return;
        }
        for (int i = indexStrs; i < numbers.Length; i++)
        {
            readyComb[indexReadyComb] = numbers[i];
            recursion(indexReadyComb + 1, i + 1);
        }
    }
}