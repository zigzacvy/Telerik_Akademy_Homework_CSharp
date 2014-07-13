using System;

class FloatOrDouble
{
    static void Main()
    {
        float firstFloat = 12.345f;
        float secondFloat = 3456.091f;
        double firstDouble = 8923.123487d;
        double secondDouble = 34.567839023d;

        Console.WriteLine("float for {0} and {1}; double for {2} and {3}", 
            firstFloat, secondFloat, firstDouble, secondDouble);
    }
}

