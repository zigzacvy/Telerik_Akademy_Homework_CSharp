using System;

class GreatestCommonDivisor
{
    static int gcd(int x, int y)
    {

        if (y == 0)
        {
            return x;
        }

        else
        {
            return gcd(y, x % y);
        }
     
    }

    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine(GreatestCommonDivisor.gcd(x, y));
    }
}
