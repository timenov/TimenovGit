//Declare the variables needed to keep the information for a single bank account.

using System;
using System.Text;

class BankAccount
{
    static void Main(string[] args)
    {
        string firstName = "Name";
        string midName = "Surename";
        string lastName = "Family";
        decimal balance = 123.45m;
        string bankName = "Bank";
        string IBAN = "BG38BANK1234598765432";
        string bicCode = "BANKBGSF";
        ulong firstCard = 1234567890123456;
        ulong secondCard = 6543210987654321;
        ulong thirdCard = 5437812072418530;

        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("Client's name: {0} {1} {2}", firstName, midName, lastName);
        Console.WriteLine("Account's balance: {0}{1}", balance, (char)8364);
        Console.WriteLine("\nBank: {0}", bankName);
        Console.WriteLine("\nIBAN: {0}\nBIC code: {1}", IBAN, bicCode);
        Console.WriteLine("Card numbers:\n1. {0}\n2. {1}\n3. {2}", firstCard, secondCard, thirdCard);
    }
}