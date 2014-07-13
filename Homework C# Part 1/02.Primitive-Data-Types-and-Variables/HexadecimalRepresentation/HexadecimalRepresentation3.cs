using System;

class HexadecimalRepresentation
{
    static void Main()
    {
        string hexString = "FE";
        int number = Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine(number);
    }
}


