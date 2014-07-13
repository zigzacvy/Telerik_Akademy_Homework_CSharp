using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SortThem
{
    class SortThem
    {
        static List<string> namesFromTxt = new List<string>();

        static void Main(string[] args)
        {
            string userPath = @"..\..\TestFile.txt";

            string[] stringArr = Reader(userPath);
            ListFiller(stringArr);
            namesFromTxt.Sort();
            Writer(namesFromTxt);

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

        public static void ListFiller(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                namesFromTxt.Add(arr[i]);
            }
        }

        public static void Writer(List<string> list)
        {
            StreamWriter writeInTxt = new StreamWriter("EndFile.txt");
            using (writeInTxt)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    writeInTxt.WriteLine(list[i]);
                }
            }
        }
    }
}

//Write a program that reads a text file containing
//a list of strings, sorts them and saves them to another text file. 