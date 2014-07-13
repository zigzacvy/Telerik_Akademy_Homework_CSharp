using System;

class DividWithoutEemainder
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int randomNumber = int.Parse(Console.ReadLine());

        if ((randomNumber % 5).Equals(0) && (randomNumber % 7).Equals(0))
        {
            Console.WriteLine("The number can be devided by 7 and 5.");
        }
        else
        {
            Console.WriteLine("The number can't be devided by 7 and 5.");
        }
    }
}

//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.