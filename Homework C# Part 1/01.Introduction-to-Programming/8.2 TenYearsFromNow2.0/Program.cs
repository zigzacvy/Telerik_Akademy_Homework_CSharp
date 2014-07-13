using System;


class TenYearsFromNow2
{
    static void Main()
    {
        Console.WriteLine("Enter your month.day.year of birth:");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
        int currentYear = DateTime.Now.Year;
        Console.WriteLine("Your current age is: {0}", currentYear - dateOfBirth.Year);

        int tenYearsFromNow = currentYear + 10;
        Console.WriteLine("Your age after ten years will be: {0}", tenYearsFromNow - dateOfBirth.Year);
        
        Console.WriteLine("Enter desired year to calculate your age in that year: ");
        int desireYear = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age in the desired year is: {0}",desireYear - dateOfBirth.Year);
    }
}

