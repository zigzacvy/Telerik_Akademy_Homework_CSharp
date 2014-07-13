using System;

class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Enter company's name:");
        string companyName = Console.ReadLine();

        Console.WriteLine("Enter comapny's adress:");
        string companyAdress = Console.ReadLine();

        Console.WriteLine("Enter comany's phone number:");
        int companyPhoneNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter comany's fax number:");
        int companyFaxNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter comapny's web site:");
        string companyWebSite = Console.ReadLine();

        Console.WriteLine("Enter menager's first name:");
        string managerFirstName = Console.ReadLine();

        Console.WriteLine("Enter menager's last name:");
        string menagerLastName = Console.ReadLine();

        Console.WriteLine("Enter menager's age:");
        int menagerAge = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter menager's phone number:");
        int menagerPhoneNumber = int.Parse(Console.ReadLine());
    }
}


//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and 
//its manager and prints them on the console.