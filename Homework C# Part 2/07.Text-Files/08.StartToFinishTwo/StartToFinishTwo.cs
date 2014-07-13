using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.OddDeleting
{
    class Program
    {
        static string[] text;

        static void Main(string[] args)
        {
            string userPath = @"..\..\Start.txt";

            Reader(userPath);
            Writer(userPath);
        }

        public static void Reader(string path)
        {
            StreamReader readFromTxt = new StreamReader(path);
            using (readFromTxt)
            {
                Regex rgx = new Regex(@"\b(start)\b");
                text = readFromTxt.ReadToEnd().Split('\n');
                for (int i = 0; i < text.Length; i++)
                {
                    text[i] = rgx.Replace(text[i], "finish");
                }                
            }
        }

        public static void Writer(string path)
        {
            StreamWriter writeInTxt = new StreamWriter(path);
            using (writeInTxt)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    writeInTxt.WriteLine(text[i]);
                }
            }
        }
    }
}

//Modify the solution of the previous problem to replace only whole words (not substrings).