using System;

class ChooseVariable
{
    static void Main()
    {
        Console.WriteLine("Choose 1 for int, 2 for double, 3 for string.");
        int usersChoice = int.Parse(Console.ReadLine());

        switch (usersChoice)
        {
            case 1:
                Console.WriteLine("Enter int:");
                int usersChoiceOne = int.Parse(Console.ReadLine());
                Console.WriteLine(usersChoiceOne + 1); break;
            case 2:
                Console.WriteLine("Enter double:");
                double usersChoiceTwo = double.Parse(Console.ReadLine());
                Console.WriteLine(usersChoiceTwo + 1); break;
            case 3:
                Console.WriteLine("Enter string:");
                string usersChoiceThree = Console.ReadLine();
                Console.WriteLine(usersChoiceThree + "*"); break;
        }
    }
}

//Write a program that, depending on the user's choice inputs int, double or string variable. 
//If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
//The program must show the value of that variable as a console output. Use switch statement.