// Which of the following values can be assigned to a variable of type float or double
// 34.567839023, 12.345, 8923.1234857, 3456.091

using System;

class ChooseType
{
    static void Main()
    {
        double firstNumb = 34.567839023;
        float secondNumb = 12.345f;
        double thirdNumb = 8923.1234857;
        float fourthNumb = 3456.091f;

        Console.WriteLine("Numbers are:\n\t{0}\n\t{1}\n\t{2}\n\t{3}", firstNumb, secondNumb, thirdNumb, fourthNumb);
    }
}