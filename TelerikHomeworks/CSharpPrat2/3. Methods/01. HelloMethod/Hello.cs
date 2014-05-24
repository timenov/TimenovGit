//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
using System;

class Hello
{
    static void HelloMethod()
    {
        Console.Write("What's your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        HelloMethod();
    }
}