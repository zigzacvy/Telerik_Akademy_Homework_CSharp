using System;
using System.Text;

class SingleEmployeeInformation
{
    static void Main()
    {
        Console.WriteLine("Enter your first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter your family name:");
        string familyName = Console.ReadLine();

        Console.WriteLine("Enter your age:");
        byte age = byte.Parse(Console.ReadLine());

        char gender;
        do
        {
            Console.WriteLine("Enter gender m/f: ");
            gender = char.Parse(Console.ReadLine());
        }
        while (!(gender == 'f' || gender == 'm'));

        Console.WriteLine("Enter employee number:");
        int emplNumber = int.Parse(Console.ReadLine());
    }
}
