using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.URLParser
{
    class URLParser
    {
        static void Main(string[] args)
        {
            string userURL = "http://www.devbg.org/forum/index.php";

            var elements = Regex.Match(userURL, "(.*)://(.*?)(/.*)").Groups;

            Console.WriteLine(elements[1]);
            Console.WriteLine(elements[2]);
            Console.WriteLine(elements[3]);
        }
    }
}//Many thanks to @jasssonpet.

//Write a program that parses an URL address given in the format and extracts from
//it the [protocol], [server] and [resource] elements. For example from the URL
//http://www.devbg.org/forum/index.php the following information should be extracted: