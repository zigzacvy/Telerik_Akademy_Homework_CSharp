using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TryCatchGoodBye
{
    class TryCatchGoodBye
    {
        static void Main(string[] args)
        {
            Console.Write("Enter random number: ");            

            try
            {
                uint ranNum = uint.Parse(Console.ReadLine());
                Console.WriteLine("The square root of {0} is {1}.",ranNum, Math.Sqrt(ranNum));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}

//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". 
//Use try-catch-finally.