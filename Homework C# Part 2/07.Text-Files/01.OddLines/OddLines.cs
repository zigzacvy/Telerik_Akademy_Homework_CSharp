using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            StreamReader readFromTxt = new StreamReader(@"..\..\TestFile.txt");
            using (readFromTxt)
            {
                string[] inTxtText = readFromTxt.ReadToEnd().Split('\n');
                
                for (int i = 0; i < inTxtText.Length; i++)
                {
                    if (i % 2 == 0) Console.WriteLine(inTxtText[i]);                    
                }
            }
        }
    }
}

//Write a program that reads a text file and prints on the console its odd lines.
