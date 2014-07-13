using System;

class StringToObject
{
    static void Main()
    {
        string stringOne = "Hello";
        string stringTwo = "world";
        object toObject = stringOne + "," + " " + stringTwo + "!";
        string stringThree = (string)toObject;

        Console.WriteLine(toObject);
        Console.WriteLine(stringThree);
    }
}
