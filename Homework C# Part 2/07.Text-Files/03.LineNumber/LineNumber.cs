using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LineNumber
{
    class LineNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the path to the file (..\\..\\FileName.txt): ");
            string userPath = Console.ReadLine();

            string[] textArr= Reader(userPath);
            Writer(textArr);

            Console.WriteLine(@"Your file is in ""C:\...\02.TwoInOne\bin\Debug""");
        }

        public static string[] Reader(string path)
        {
            StreamReader readFromTxt = new StreamReader(path);
            using (readFromTxt)
            {
                string[] inTxtText = readFromTxt.ReadToEnd().Split('\n');

                return inTxtText;
            }
        }

        public static void Writer(string[] textOne)
        {
            StreamWriter writeInTxt = new StreamWriter("EndFile.txt");
            using (writeInTxt)
            {
                for (int i = 0; i < textOne.Length; i++)
                {
                    writeInTxt.WriteLine((i+1)+textOne[i]);
                }
            }
        }
    }
}

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.