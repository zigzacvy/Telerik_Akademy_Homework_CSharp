using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ThatTask
{
    class NoIdeaWhatThisShouldDo
    {
        static void Main(string[] args)
        {
            //Input
            int numberS;
            do
            {
                Console.Write("Eter \"s\": ");
                numberS = int.Parse(Console.ReadLine());
            } while (numberS < 2);

            int numberD;
            do
            {
                Console.Write("Eter \"d\": ");
                numberD = int.Parse(Console.ReadLine());
            } while (numberD < 2 && numberD > 16);

            Console.Write("Enter the number to convert from \"s\" to \"d\": ");
            string oldNumber = Console.ReadLine();

            //Calculator

            //First transform, from "s" to decimal
            int decNum = 0;
            int sMultiplier = 1;

            for (int i = oldNumber.Length - 1; i >= 0; i++)
            {
                decNum += sMultiplier;
                sMultiplier *= numberS;
            }

            //Second transform, to "d"
            string[] dNum = new string[32];
            int testProd = decNum;
            int tempProd = decNum;
            int dProduct = numberD;
            int sum = 0;

            for (int i = 31; i > 0; i--)
            {
                testProd %= dProduct;
                dNum[i] = Convert.ToString(testProd);
                sum += testProd;
                tempProd /= dProduct;
                testProd = tempProd;
                
            }
            Console.WriteLine(sum);    //OMG WTF... Не мога... не разбирам условеието... не може просто така...
            Printer(dNum);             //Как така в петнайсетична например... пълни глупости...
        }                              //и защо подяволите мисли толкова много...

        public static void Printer(string[] array)
        {
            Console.Write("The \"d\" number is ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
        //Go on... hame some 
    }
}

//Write a program to convert from any numeral system of given
//base s to any other numeral system of base d (2 ≤ s, d ≤  16).