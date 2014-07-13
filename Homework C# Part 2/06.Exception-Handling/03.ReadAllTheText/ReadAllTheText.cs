using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.ReadAllTheText
{
    class ReadAllTheText
    {
        static void Main(string[] args)
        {
            Console.Write("Enter tha path to the file: ");
            string userPath = Console.ReadLine();

            try
            {
                string readText = File.ReadAllText(userPath);
                Console.WriteLine(readText);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Error!");
            }            
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Error!");
            }
            catch (IOException)
            {
                Console.WriteLine("Error!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Error!");
            }            
        }
    }
}

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.