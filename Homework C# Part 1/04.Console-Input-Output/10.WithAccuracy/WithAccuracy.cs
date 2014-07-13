using System;

class WithAccuracy
{
    static void Main()
    {
        decimal numerator = 2;
        decimal sum = 1;
        int sign = 1;
       
        while (numerator <= 1000)
        {
            sum = sum + 1 / (sign * numerator);
            numerator = numerator + 1;
            sign = sign * (-1);
        }
        Console.WriteLine("{0:0.000}", sum);      
    }
}


//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...