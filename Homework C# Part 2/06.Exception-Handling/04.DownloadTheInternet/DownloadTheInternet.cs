using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _04.DownloadTheInternet
{
    class DownloadTheInternet
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the URL: ");
            string userUrl = Console.ReadLine();
            Console.Write("Enter save directory: ");
            string userDir = Console.ReadLine();

            using (WebClient a = new WebClient)
            {

                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(userUrl, userDir);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Error!");
                }
                catch (WebException)
                {
                    Console.WriteLine("Error!");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("Error!");
                }
            }

            Console.WriteLine("Done!");
        }
    }
}

//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and 
//stores it the current directory. Find in Google how to download files in C#. Be sure to catch all exceptions 
//and to free any used resources in the finally block.