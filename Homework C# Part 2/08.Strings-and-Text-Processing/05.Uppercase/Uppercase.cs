using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Uppercase
{
    class Uppercase
    {
        static void Main(string[] args)
        {
            string userStr = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
                       int opentag = 0;
            int closetag = 0;
            string ffs = userStr;

            while (opentag != -1)
            {
                opentag = userStr.IndexOf("<upcase>", closetag);
                if (opentag != -1)
                {
                    closetag = userStr.IndexOf("</upcase>", opentag);
                    string work = userStr.Substring(opentag + 8, closetag - opentag - 8);
                    string upper = work.ToUpper();

                    ffs = ffs.Replace("<upcase>" + work + "</upcase>", upper);
                }
            }
            Console.WriteLine(ffs);
        }
    }
} //Many thanks to @makmidov!

//You are given a text. Write a program that changes the text in all regions surrounded
//by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example: