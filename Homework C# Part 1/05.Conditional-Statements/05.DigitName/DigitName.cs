using System;

class DigitName
{
    static void Main()
    {
        Console.WriteLine("Enter random digit:");
        int digit = int.Parse(Console.ReadLine());

        switch (digit)
        {
            case 0:
                Console.WriteLine("The word for {0} is zero.", digit); break;
            case 1:
                Console.WriteLine("The word for {0} is one.", digit); break;
            case 2:
                Console.WriteLine("The word for {0} is two.", digit); break;
            case 3:
                Console.WriteLine("The word for {0} is three.", digit); break;
            case 4:
                Console.WriteLine("The word for {0} is four.", digit); break;
            case 5:
                Console.WriteLine("The word for {0} is fice.", digit); break;
            case 6:
                Console.WriteLine("The word for {0} is six.", digit); break;
            case 7:
                Console.WriteLine("The word for {0} is seven.", digit); break;
            case 8:
                Console.WriteLine("The word for {0} is eight.", digit); break;
            case 9:
                Console.WriteLine("The word for {0} is nine.", digit); break;
        }
    }
}

//Write program that asks for a digit and depending on the input shows the name of 
//that digit (in English) using a switch statement.