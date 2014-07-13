using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18.SomethingToDoWithMails
{
    class MailsMails
    {
        static void Main(string[] args)
        {
            string testStr = @"ASD asdasdasd dsa asddas asd@asd.asd asdsadasd dsadsa asd dsaasd
asdasddsadasd dsadsad dsa asddsadasd dsa@fgigji.dsa.";

            foreach (var mail in Regex.Matches(testStr, @"\w+@\w+\.\w+"))
            {
                Console.WriteLine(mail);
            }
        }
    }
}

//Write a program for extracting all email addresses from given text. All substrings
//that match the format <identifier>@<host>…<domain> should be recognized as emails.