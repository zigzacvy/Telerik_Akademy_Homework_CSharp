using System;

class HexadecimalRepresentation2
{
    static void Main()
    {
        int number = 254;
        string hexString = number.ToString("X"); 
        Console.WriteLine("The hexadecimal representation of {0} is {1}.",number,hexString);
    }
}

