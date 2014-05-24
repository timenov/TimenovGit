// Declare an integer variable and assign it with the value 254 in hexademical format.

using System;

class DeclareIntVariable
{
    static void Main()
    {
        int number = '\u00FE';
        Console.WriteLine("The number is: {0}", number);
    }
}