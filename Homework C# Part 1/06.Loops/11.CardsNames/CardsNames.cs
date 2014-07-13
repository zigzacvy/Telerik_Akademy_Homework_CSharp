using System;

class CardsNames
{
    static void Main()
    {
        string[] signs = {" of Hearts", " of Spades", " of Diamonds", " of Clubs" };
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        for (int i = 0; i < 13; i++)
        {
            for (int f = 0; f < 4; f++)
            {
                Console.WriteLine(cards[i] + signs[f]);
            }
        }
    }
}

