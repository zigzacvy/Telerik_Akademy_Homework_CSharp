using System;

class BooleanGender
{
    static void Main()
    {
        string myGender = "male";
        string myGenderNot = "female";
        bool isMale = (myGender != myGenderNot);

        if (isMale)
        {
            Console.WriteLine("I'm a man.");
        }
        else
        {
            Console.WriteLine("I'm not.");
        }

        Console.WriteLine("I am: " + isMale);
    }
}
