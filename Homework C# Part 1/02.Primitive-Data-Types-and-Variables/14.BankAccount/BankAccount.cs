using System;

class BankAccount
{
    static void Main()
    {
        Console.WriteLine("First name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Middle name:");
        string middleName = Console.ReadLine();
        Console.WriteLine("Last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Balance:");
        decimal balance = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Bank name:");
        string bankName = Console.ReadLine();
        Console.WriteLine("IBAN:");
        string IBAN = Console.ReadLine();
        Console.WriteLine("BIC:");
        string BIC = Console.ReadLine();
        Console.WriteLine("Credit card numbers (3):");
        ulong cardNumberOne = ulong.Parse(Console.ReadLine());
        ulong cardNumberTwo = ulong.Parse(Console.ReadLine());
        ulong cardNumberThree = ulong.Parse(Console.ReadLine());
    }
}

