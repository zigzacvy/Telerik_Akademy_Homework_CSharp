using System;

class NumbersBetweenNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter start number:");
        int startNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end number:");
        int endNumber = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int i = startNumber; i <= endNumber; i++)
        {
            if ((i % 10).Equals(5) || (i % 10).Equals(0))
            {
                counter++;
            }
        }
        Console.WriteLine("Reminder of the division by 5 is 0 for {0} numbers",counter);
    }
}


//Write a program that reads two positive integer numbers and prints how many
//numbers p exist between them such that the reminder of the division
//by 5 is 0 (inclusive). Example: p(17,25) = 2.