using System;

class HowOldYouWillBe
{
    static void Main(string[] args)
    {
        Console.WriteLine("How old are you?");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("After 10 years you will be " + (age + 10) + " years old.");
    }
}
