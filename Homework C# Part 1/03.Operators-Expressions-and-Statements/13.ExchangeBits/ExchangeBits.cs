using System;

class ExchangeBits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int mask = 1 << 3;
        int thirdBit = (number & mask) >> 3;

        mask = 1 << 24;
        int twentiFourBit = (number & mask) >> 24;

        if (thirdBit == twentiFourBit)
        {
            Console.WriteLine(number);
            return;
        }

        if (thirdBit == 0)
        {
            mask = ~(1 << 24);
            number = number & mask;
        }
        else
        {
            mask = 1 << 24;
            number = number | mask;
        }

        if (twentiFourBit == 0)
        {
            mask = ~(1 << 0);
            number = number & mask;
        }
        else
        {
            mask = 1 << 3;
            number = number | mask;
        }
        Console.WriteLine(number);
    }
}


//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.