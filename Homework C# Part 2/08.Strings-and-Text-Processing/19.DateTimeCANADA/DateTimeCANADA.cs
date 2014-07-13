using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _19.DateTimeCANADA
{
    class DateTimeCANADA
    {
        static void Main(string[] args)
        {
            string testStr = @"ASD asdasdasd dsa asddas 07.03.1234 asdsadasd dsadsa asd dsaasd
asdasd 17.05.1234 dsadasd dsadsad dsa asddsadasd 07.05.1534.";

            foreach (var date in Regex.Matches(testStr, @"\b\d{2}.\d{2}.\d{4}\b"))
            {
                string strdate=date.ToString();
                DateTime dateCa = DateTime.ParseExact(strdate, "dd.MM.yyyy", new CultureInfo("en-CA"));
                strdate = dateCa.ToString();
                Console.WriteLine(strdate);
            }
        }
    }
}

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.