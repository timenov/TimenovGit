// Declare a character variable and assign it with the symbol that has Unicode code 72.

using System;

class DeclareCharVariable
{
    static void Main()
    {
        char symbol = '\u0048';
        Console.WriteLine("The symbol is: {0}", symbol);
    }
}