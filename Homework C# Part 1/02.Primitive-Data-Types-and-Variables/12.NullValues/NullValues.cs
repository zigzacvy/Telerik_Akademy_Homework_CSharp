using System;

class NullValues
{
    static void Main()
    {
        int? intNumber = null;
        double? doubleNumber = null;
        int? addValueInt = intNumber + 2;
        double? addValueDouble = doubleNumber + 3;
       
        Console.WriteLine("intNumber={0}, doubleNumber={1}, addValueInt={2}, addValueDouble={3}.",intNumber,doubleNumber,addValueInt,addValueInt);

    }
}

