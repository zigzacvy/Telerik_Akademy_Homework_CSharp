using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.TagReplacer
{
    class TagReplacer
    {
        static void Main(string[] args)
        {
            string testHTML = @"<p>Please visit <a href=""http://academy.telerik.com"">our
site</a> to choose a training course. Also visit <a href=""www.devbg.org""
>our forum</a> to discuss the courses.</p>";

            string newHTML = testHTML.Replace(@"<a href=""", "[URL=]");
            newHTML = newHTML.Replace(@""">", "]");
            newHTML = newHTML.Replace("</a>", "[/URL]");
            newHTML = newHTML.Trim('"');

            Console.WriteLine(newHTML);
        }
    }
}

//Many thanks to @kristina.bankova.

//Write a program that replaces in a HTML document given as string all the tags
//<a href="…">…</a> with corresponding tags [URL=…]…/URL].