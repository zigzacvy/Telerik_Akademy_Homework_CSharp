using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Substring
{
    public static class SubstringExtension
    {
        public static string Substring(this StringBuilder str, int startIndex, int length)
        {
            return str.ToString().Substring(startIndex, length);
        }
    }
}

//Implement an extension method Substring(int index, int length) for the
//class StringBuilder that returns new StringBuilder and has the same 
//functionality as Substring in the class String.