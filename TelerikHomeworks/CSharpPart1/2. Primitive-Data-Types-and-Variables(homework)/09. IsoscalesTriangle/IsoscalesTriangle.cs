//Write a program that prints an isosceles triangle of 9 copyright symbols ©.

using System;
using System.Text;

class IsoscalesTriangle
{
    static void Main()
    {
        char symbol = '\u00A9';
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("   {0}\n  {0} {0}\n {0}   {0}\n{0} {0} {0} {0}", symbol);
    }
}