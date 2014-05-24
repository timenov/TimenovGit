//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class ValuesExchange
{
    static void Main()
    {
        int firstInt = 5;
        int secondInt = 10;
        Console.WriteLine("Variable values before exchange.");
        Console.WriteLine("first int: {0}\nsecond int: {1}\n", firstInt, secondInt);
        
        int temp = firstInt; // temp = 5
        firstInt = secondInt; // firstInt = 10
        secondInt = temp; // secondInt = 5

        Console.WriteLine("Variable values after exchange.");
        Console.WriteLine("first int: {0}\nsecond int: {1}", firstInt, secondInt);
    }
}