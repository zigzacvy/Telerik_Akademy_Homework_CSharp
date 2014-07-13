using System;

class CompareNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number with more than seven digits after decaminal point:");
        decimal numberOne = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter number with more than seven digits after decaminal point:");
        decimal numberTwo = decimal.Parse(Console.ReadLine());
        
        string numberAsString1 = numberOne.ToString().Substring(0, numberOne.ToString().IndexOf('.') + 7);
        string numberAsString2 = numberTwo.ToString().Substring(0, numberTwo.ToString().IndexOf('.') + 7);
        
        if (decimal.Parse(numberAsString1) == decimal.Parse(numberAsString2))
        {
            Console.WriteLine(true);
        }
        else
            Console.WriteLine(false);
    }
}

