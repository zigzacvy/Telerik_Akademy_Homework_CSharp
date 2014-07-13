using System;

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The greather of the two numbers is {0}.", Math.Max(firstNumber,secondNumber));
    }
}


//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
