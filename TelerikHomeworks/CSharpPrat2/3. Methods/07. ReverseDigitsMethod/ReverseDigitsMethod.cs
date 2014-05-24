using System;
using System.Text;

class ReverseDigitsMethod
{
    static string ReverseDigits(string number)
    {
        StringBuilder newNumber = new StringBuilder();
        char[] digits = number.ToCharArray();
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            newNumber.Append(digits[i]);
        }
        return newNumber.ToString();
    }

    static void Main()
    {
        Console.Write("enter number: ");
        string number = Console.ReadLine();

        Console.WriteLine("reversed: {0}", ReverseDigits(number));
    }
}