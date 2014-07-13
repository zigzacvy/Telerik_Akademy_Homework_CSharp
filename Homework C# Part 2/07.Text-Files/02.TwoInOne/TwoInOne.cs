using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TwoInOne
{
    class TwoInOne
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the path to the file one (..\\..\\FileName.txt): ");
            string userPathOne = Console.ReadLine();
            Console.Write("Enter the path to the file two(..\\..\\FileName.txt): ");
            string userPathTwo = Console.ReadLine();

            string textFileOne = Reader(userPathOne);
            string textFileTwo = Reader(userPathTwo);
            Writer(textFileOne, textFileTwo);

            Console.WriteLine(@"Your file is in ""C:\...\02.TwoInOne\bin\Debug""");
        }

        public static string Reader(string path)
        {
            StreamReader readFromTxt = new StreamReader(path);
            using (readFromTxt)
            {
                string inTxtText = readFromTxt.ReadToEnd();

                return inTxtText;
            }
        }

        public static void Writer(string textOne, string textTwo)
        {
            StreamWriter writeInTxt = new StreamWriter("EndFile.txt");
            using(writeInTxt)
            {
                writeInTxt.WriteLine(textOne +'\n'+ textTwo);
            }
        }
    }
}


//Write a program that concatenates two text files into another text file.