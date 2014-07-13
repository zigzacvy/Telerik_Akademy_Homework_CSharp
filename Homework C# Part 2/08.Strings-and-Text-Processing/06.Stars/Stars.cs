using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stars
{
    class Stars
    {
        static void Main(string[] args)
        {
            string userString;
            do
            {
                Console.Write("Enter string with maximum lenght of 20 chars: ");
                userString=Console.ReadLine();                
            }while(userString.Length>20);

            string stars=new string('*',20-userString.Length);

            if (userString.Length < 20)
            {
                userString += stars;
            }

            Console.WriteLine(userString);
        }       
    }
}

//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should
//be filled with '*'. Print the result string into the console.
