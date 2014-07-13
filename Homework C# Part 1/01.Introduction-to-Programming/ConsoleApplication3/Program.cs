using System;

class TenYearsFromNow
{
    static void Main()
    {
        Console.WriteLine("Type your age:");
        int age = int.Parse(Console.ReadLine());
        int tenYearsFromNow = age + 10;
        Console.WriteLine("Your age after ten years will be : {0}", tenYearsFromNow);
    }
}

