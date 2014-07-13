using System;

class TheThirdDigit
{
    static void Main()
    {
        int randomNumber;
        do
        {
            Console.WriteLine("Enter number:");
            randomNumber = int.Parse(Console.ReadLine());
        }
        while (!(randomNumber >= 100));

        if (((randomNumber / 100) % 10).Equals(7)) 
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }     
    }
}

//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.