using System;

class DescendingOrder
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers on a new lane:");

        Console.Write("a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b:");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c:");
        int c = int.Parse(Console.ReadLine());

        if (a < b)
        {
            if (b < c)
            {
                Console.WriteLine("{0}, {1}, {2}", a, b, c);
            }
            else
            {
                if (c < a)
                {
                    Console.WriteLine("{0}, {1}, {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", a, c, b);
                }
            }
        }
        else
        {
            if (b < c)
            {
                if (a > c)
                {
                    Console.WriteLine("{0}, {1}, {2}", b, c, a);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", b, a, c);
                }
            }
            else
            {
                if (a > c)
                {
                    Console.WriteLine("{0}, {1}, {2}", c, b, a);
                }
            }
        }
    }

}

//Sort 3 real values in descending order using nested if statements.