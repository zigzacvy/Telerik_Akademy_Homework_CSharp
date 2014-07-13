using System;

class NumberValuePosition
{
    static void Main()
    {
        Console.WriteLine("Enter number \"n\":");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value \"v\":");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position \"p\":");
        int position = int.Parse(Console.ReadLine());

        if (value.Equals(0))
        {
            int mask = ~(1 << position);
            int result = number & mask;
            Console.WriteLine(result);
        }
        else
        {
            int mask = 1 << position;
            int result = number | mask;
            Console.WriteLine(result);
        }
    }
}

//We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
//Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//n = 5 (00000101), p=2, v=0  1 (00000001)