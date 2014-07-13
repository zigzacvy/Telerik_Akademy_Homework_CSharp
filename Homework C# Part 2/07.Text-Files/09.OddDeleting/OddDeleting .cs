using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.OddDeleting
{
    class Program
    {
        static string[] inTxtText;

        static void Main(string[] args)
        {
            string userPath = @"..\..\Test.txt";

            Reader(userPath);
            Writer(userPath);
        }

        public static void Reader(string path)
        {
            StreamReader readFromTxt = new StreamReader(path);
            using (readFromTxt)
            {

                inTxtText = readFromTxt.ReadToEnd().Split('\n');
            }
        }

        public static void Writer(string path)
        {
            StreamWriter writeInTxt = new StreamWriter(path);
            using (writeInTxt)
            {
                {
                    for (int i = 0; i < inTxtText.Length; i++)
                    {
                        if (i % 2 != 0) writeInTxt.WriteLine(inTxtText[i]);
                    }
                }
            }
        }
    }
}

//Write a program that deletes from given text file all odd lines. The result should be in the same file.