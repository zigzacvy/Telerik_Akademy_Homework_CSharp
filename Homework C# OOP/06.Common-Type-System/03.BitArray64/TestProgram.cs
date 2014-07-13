using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BitArray64
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            BitArray64 userTestInputOne = new BitArray64(5643);
            BitArray64 userTestInputTwo = new BitArray64(4356);
            BitArray64 userTestInputThree = new BitArray64(5643);


            bool testOne = userTestInputOne.Equals(userTestInputTwo);
            bool testTwo = userTestInputOne.Equals(userTestInputThree);
            int testHashCode = userTestInputOne.GetHashCode();
            int testIndexOne = userTestInputOne[62];
            int testIndexTwo = userTestInputOne[61];
            bool testThree = userTestInputOne == userTestInputTwo;

            Console.WriteLine(userTestInputOne.Value);
            Console.WriteLine(userTestInputOne.ToString());
            Console.WriteLine(testOne);
            Console.WriteLine(testTwo);
            Console.WriteLine(testThree);
            Console.WriteLine(testHashCode);
            Console.WriteLine(testIndexOne);
            Console.WriteLine(testIndexTwo);
        }
    }
}
