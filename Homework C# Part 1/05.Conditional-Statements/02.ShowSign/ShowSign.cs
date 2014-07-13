using System;

class ShowSign
{
    static void Main()
    {
        Console.WriteLine("Enter number with his sign on a new line:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (c > 0 && b > 0 && a > 0 ||
            c < 0 && b < 0 && a > 0 ||
            c < 0 && b > 0 && a < 0 ||
            c > 0 && b < 0 && a < 0)
        {
            Console.WriteLine("The product if the entered numbers is a positive number.");
        }
        else
        {
            Console.WriteLine("The product if the entered numbers is a negative number.");
        }
    }
}

//Write a program that shows the sign (+ or -) of the product of three real
//numbers without calculating it. Use a sequence of if statements.

