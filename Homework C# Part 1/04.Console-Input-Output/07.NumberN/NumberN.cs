using System;

class NumberN
{
    static void Main()
    {
        Console.WriteLine("Enter number n:");
        int numberN = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 0; i < numberN; i++)
        {
            Console.WriteLine("Enter random number:");
            int enterNumber = int.Parse(Console.ReadLine());
            sum = sum + enterNumber;
        }
        Console.WriteLine("The sum of n random numbers is {0}.", sum);
    }
}

//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum.
