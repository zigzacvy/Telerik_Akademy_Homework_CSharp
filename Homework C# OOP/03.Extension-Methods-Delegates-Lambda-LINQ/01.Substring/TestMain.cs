using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01.Substring
{
    class TestMain
    {
        static void Main(string[] args)
        {
            StringBuilder userStr = new StringBuilder();
            userStr.Append("Say hello to the user, extension!");

            string outPut = userStr.Substring(4, 5);
            Console.WriteLine(outPut);
        }
    }
}


//Implement an extension method Substring(int index, int length) for the
//class StringBuilder that returns new StringBuilder and has the same
//functionality as Substring in the class String.