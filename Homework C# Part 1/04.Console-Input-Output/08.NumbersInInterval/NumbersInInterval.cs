using System;

class NumbersInInterval
{
    static void Main()
    {
        Console.WriteLine("Enter number n:");
        int numberN = int.Parse(Console.ReadLine());

        Console.WriteLine("Numbers in the interval [1...n] are:");

        for (int i = 0; i < numberN; i++)
        {
            Console.WriteLine(1 + i);
        }
    }
}

//Write a program that reads an integer number n from the console and 
//prints all the numbers in the interval [1..n], each on a single line.