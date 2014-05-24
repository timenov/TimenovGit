//A marketing firm wants to keep record of its employees. Each record would have the following characteristics:
//first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999).

using System;

class EmployessData
{
    static void Main()
    {
        string firstName = "Name";
        string lastName = "Family";
        byte age = 32;
        char gender = 'm';
        uint ID = 27569234;

        Console.WriteLine("Person: {0} {1}\nage: {2}\ngender: {3}\nID number: {4}",
            firstName, lastName, age, gender, ID);
    }
}