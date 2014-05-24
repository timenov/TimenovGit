// Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class CompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Enter company info:");

        Console.Write("name: ");
        string compName = Console.ReadLine();

        Console.Write("address: ");
        string compAddress = Console.ReadLine();

        Console.Write("phone number: ");
        string compPhone = Console.ReadLine();

        Console.Write("fax number: ");
        string compFax = Console.ReadLine();

        Console.Write("website: ");
        string compWeb = Console.ReadLine();

        Console.WriteLine("Enter manager info: ");

        Console.Write("first name: ");
        string manFirstName = Console.ReadLine();

        Console.Write("last name: ");
        string manLastName = Console.ReadLine();

        Console.Write("age: ");
        byte manAge = byte.Parse(Console.ReadLine());

        Console.Write("phone: ");
        string manPhone = Console.ReadLine();

        Console.WriteLine("\n\n"); // add 3 empty lines

        Console.WriteLine("Company info:");
        Console.WriteLine("name: {0}\naddress: {1}\nphone: {2}\nfax: {3}\nwebsite: {4}", compName, compAddress, compPhone, compFax, compWeb);

        Console.WriteLine("\nManager info:");
        Console.WriteLine("first name: {0}\nlast name: {1}\nage: {2}\nphone number: {3}", manFirstName, manLastName, manAge, manPhone);
    }
}