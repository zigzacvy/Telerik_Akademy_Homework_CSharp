using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListTest
{
    class TestInput
    {
        static void Main(string[] args)
        {
            GenericList<int> inputTest = new GenericList<int>(10);

            //Adding
            inputTest.Add(5);
            inputTest.Add(8);
            inputTest.Add(10);
            inputTest.Add(3);
            
            //Accessing
            int value= inputTest.AccessingByIndex(2);

            //Removing
            inputTest.Delete(2);

            //Inserting 
            inputTest.Insert(1, 80);

            //Clearing
            //inputTest.Clear();

            //Finding element
            int index= inputTest.FindByValue(80);

            //ToString
            string output = inputTest.ToString();

            //Min value
            int minVal = inputTest.MinT();

            //Max value
            int maxVal = inputTest.MaxT();

            Console.WriteLine();
        }
    }
}
