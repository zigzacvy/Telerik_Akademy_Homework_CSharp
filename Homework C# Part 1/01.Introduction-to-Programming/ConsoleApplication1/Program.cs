using System;

class FirstAndLastName
{
    static void Main()
    {
        Console.WriteLine("Write your first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Write your second name:");
        string secondName = Console.ReadLine();

        Console.WriteLine("Write your last name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Your first and last name are: ");

        Console.WriteLine(firstName + " " + lastName);
    }
}

