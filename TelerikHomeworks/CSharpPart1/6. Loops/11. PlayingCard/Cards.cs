//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
using System;

class Cards
{
    static void Main()
    {
        string[] suit = { "Spades", "Hearts", "Diamonds", "Clubs" };
        string[] cards = { "Ace", "Deuces", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

        for (int i = 0; i < suit.Length; i++)
        {
            Console.Write("{0} - ", suit[i]);
            for (int j = 0; j < cards.Length; j++)
            {
                Console.Write("{0}, ", cards[j]);
            }
            Console.WriteLine("\b\b\0"); // this line delete last ", " and goes on new line
        }
    }
}
