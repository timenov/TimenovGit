// Content of the task is in the program:

using System;

class HelloWorld
{
    static void Main()
    {
        // Declare two string variables and assign with...
        string firstWord = "Hello";
        string secondWord = "World";
        
        // Declare an object variable an assign it with the concatenation of the first two string
        object objSentence = firstWord + " " + secondWord;

        // Declare a third string variable and initialize it with the value of the object variable
        string strSentence = (string) objSentence;
        
        Console.WriteLine("Content of object variable is: {0}", objSentence);
        Console.WriteLine("Content of string variable is: {0}", strSentence);
    }
}