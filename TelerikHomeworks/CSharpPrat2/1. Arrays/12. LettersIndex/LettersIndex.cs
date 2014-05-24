//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class LettersIndex
{
    static void Main()
    {
        char[] letters = new char[26];
        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = (char)(i + 65);
        }
        Console.Write("Write a word: ");
        string word = Console.ReadLine();
        word = word.ToUpper();
        char[] wordLetters = word.ToCharArray();

        foreach (char letter in wordLetters)
        {
            Console.WriteLine("index of {0} is {1}",letter, Array.IndexOf(letters, letter));
        }
    }
}