using System;

class TheThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int randomNumber = int.Parse(Console.ReadLine());

        if ((randomNumber & 8).Equals(8))
        {
            Console.WriteLine("The bit 3 counting from 0 is 1.");
        }
        else
        {
            Console.WriteLine("The bit 3 counting from 0 is 0.");
        }
    }
}

//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.