using System;

class UserChoice
{
    static void Main()
    {
        Console.WriteLine("Please choose your variable type:");
        Console.WriteLine("1) int\n2) double\n3) string");
        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.Write("Enter value of integer variable: ");
                int varInt = int.Parse(Console.ReadLine());
                varInt++;
                Console.WriteLine("Your variable is integer with value {0}", varInt);
                break;
            case 2: Console.Write("Enter value of double variable: ");
                double varDouble = double.Parse(Console.ReadLine());
                varDouble++;
                Console.WriteLine("Your variable is double with value {0}", varDouble);
                break;
            case 3: Console.Write("Enter string variable: ");
                string varStr = Console.ReadLine() + "*";
                Console.WriteLine("Your string is: {0}", varStr);
                break;
            default: Console.WriteLine("You make wrong choice!");
                break;
        }
    }
}