using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ManySubstringsThereAre
{
    class ManySubstringsThereAre
    {
        static void Main(string[] args)
        {
            string givenText = @"We are living in an yellow submarine. We don't have anything else.
Inside the submarine is very tight. So we are drinking all the day.
We will move out of it in 5 days.";
            int counter = 0;

            for (int i = 0; i < givenText.Length; i++)
            {
                if (givenText[i] == 'i' && givenText[i + 1] == 'n' ||
                    givenText[i] == 'I' && givenText[i + 1] == 'n') counter++;
            }
            Console.WriteLine(counter);
        }
    }
}

//Write a program that finds how many times a substring is contained in
//a given text (perform case insensitive search).