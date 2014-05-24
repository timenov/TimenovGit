//Create a program that assigns null values to an integer and to double variables.
//Try to print them on the console, try to add some values or the null literal to them and see the result.


using System;

class NullValues
{
    static void Main()
    {
        int? varInt = null;
        double? varDouble = null;

        Console.WriteLine("This is variables with null values.");
        Console.WriteLine("integer: {0}\ndouble: {1}\n", varInt, varDouble);

        varInt = 5;
        varDouble = 5;

        Console.WriteLine("This is variables with added values.");
        Console.WriteLine("integer: {0}\ndouble: {1}\n", varInt, varDouble);
    }
}