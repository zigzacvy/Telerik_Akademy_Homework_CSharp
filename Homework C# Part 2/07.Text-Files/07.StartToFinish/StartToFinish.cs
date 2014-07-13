using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.StartToFinish
{
    class StartToFinish
    {
        static string[] text;

        static void Main(string[] args)
        {
            string userFilePath = @"..\..\Start.txt";            

            Changer(userFilePath);
        }

        public static void Changer(string filePath)
        {


            StreamReader readFromTxt = new StreamReader(filePath);
            using (readFromTxt)
            {
                text = readFromTxt.ReadToEnd().Split('\n');
                for (int i = 0; i < text.Length; i++)
                {
                    string[] textArr = text[i].Split(' ');
                    for (int j = 0; j < textArr.Length; j++)
                    {
                        if (textArr[j].Equals("start")) text[i] = text[i].Replace("start", "finish");
                    }                 
                }
            }

            StreamWriter writeInTxt = new StreamWriter(filePath);
            using (writeInTxt)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    writeInTxt.Write("{0} ", text[j]);
                }
            }
        }
    }
}

//Write a program that replaces all occurrences of the substring "start" with the substring
//"finish" in a text file. Ensure it will work with large files (e.g. 100 MB).