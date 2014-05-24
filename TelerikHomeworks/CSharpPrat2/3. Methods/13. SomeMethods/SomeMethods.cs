using System;
using System.Text;

class SomeMethods
{
    static string ReverseDigits(string number)
    {
        StringBuilder reversed = new StringBuilder();
        for (int i = number.Length - 1; i >= 0; i--)
        {
            reversed.Append(number.Substring(i, 1));
        }
        return reversed.ToString();
    }
    static string ValidateReverseDigits()
    {
        Console.Write("enter positive integer: ");
        string number = Console.ReadLine();
        while (true)
        {
            if (number.Contains(".") || number.Contains("-"))
            {
                Console.WriteLine("Plase enter correct input(the number must be positive integer)!");
                number = Console.ReadLine();
            }
            else
                break;
        }
        return number;
    }
    static decimal Average(int[] array)
    {
        decimal average = 0.0m;
        for (int i = 0; i < array.Length; i++)
        {
            average += array[i];
        }
        average /= array.Length;
        return average;
    }
    static int[] ValidateAverage()
    {
        Console.WriteLine("insert elements count: ");
        int n = int.Parse(Console.ReadLine());
        while (n < 1)
        {
            Console.Write("count must be greater than 0: ");
            n = int.Parse(Console.ReadLine());
        }
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
    static decimal LinearEquation(decimal[] coef)
    {
        decimal result = (-coef[1]) / coef[0];
        return result;
    }
    static decimal[] ValidateEquation()
    {
        decimal[] array = new decimal[2];
        Console.Write("enter coef. a: ");
        array[0] = decimal.Parse(Console.ReadLine());
        while (array[0] == 0.0m)
        {
            Console.Write("'a' could not be a zero: ");
            array[0] = decimal.Parse(Console.ReadLine());
        }
        Console.Write("enter coef. b: ");
        array[1] = decimal.Parse(Console.ReadLine());
        return array;
    }
    static void Main()
    {
        Console.WriteLine("Select task: \n1) reverse digits\n2) average of a sequence\n3) linear equation");
        Console.SetCursorPosition(13, 0);
        int menu = int.Parse(Console.ReadLine());
        while (menu > 3 || menu < 1)
        {
            Console.SetCursorPosition(20, 0);
            Console.WriteLine("again");
            Console.SetCursorPosition(13, 0);
            menu = int.Parse(Console.ReadLine());
        }
        Console.SetCursorPosition(0, 5);
        switch (menu)
        {
            case 1:
                string number = ValidateReverseDigits();
                Console.WriteLine(ReverseDigits(number));
                break;
            case 2:
                int[] array = ValidateAverage();
                Console.WriteLine(Average(array));
                break;
            case 3:
                decimal[] arr = ValidateEquation();
                Console.WriteLine(LinearEquation(arr));
                break;
        }
    }
}