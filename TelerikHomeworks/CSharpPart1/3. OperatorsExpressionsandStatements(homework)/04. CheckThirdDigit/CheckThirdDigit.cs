// Write an expression that checks for given integer if its third digit (right-to-left) is 7.

using System;

class CheckThirdDigit
{
    static void Main()
    {
        Console.Write("Insert number between -2^31 and 2^31: ");
        int numb = int.Parse(Console.ReadLine());

        int temp = numb / 100; // delete last 2 digits e.g. 1732 -> 17
        temp = temp % 10; // mod of number is last digit e.g 17 -> 7

        bool isSeven = temp == 7; // if temp == 7 then isSeven = true

        Console.WriteLine("Is third digit is seven: {0}", isSeven);
    }
}