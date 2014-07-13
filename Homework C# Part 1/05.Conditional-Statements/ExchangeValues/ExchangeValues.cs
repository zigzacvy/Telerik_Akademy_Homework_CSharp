using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        int change = 0;

        if (firstNumber > secondNumber)
        {
            change = firstNumber;
            firstNumber = secondNumber;
            secondNumber = change;

            Console.WriteLine("First nymber: {0}.", firstNumber);
            Console.WriteLine("Second number: {0}.", secondNumber);
        }
        else
        {
            Console.WriteLine("First nymber: {0}.", firstNumber);
            Console.WriteLine("Second number: {0}.", secondNumber);
        }
    }
}

//Write an if statement that examines two integer variables and exchanges their
//values if the first one is greater than the second one.

