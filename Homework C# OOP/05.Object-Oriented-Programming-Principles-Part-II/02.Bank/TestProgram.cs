using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            DepositAccaunt clientOneInd = new DepositAccaunt("Peter Dimov", 2000, 8, true);
            clientOneInd.RateCalculator(14);
            clientOneInd.Withdraw(500); 
            clientOneInd.Deposit(200); 
            clientOneInd.RateCalculator(14);

            Console.WriteLine();

            LoanAccaunt clientTwoInd = new LoanAccaunt("Georgi Tapanchev", 2000, 8, true);
            try
            {
                clientTwoInd.Withdraw(10000);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
            clientTwoInd.Deposit(200);
            clientTwoInd.RateCalculator(14);

            Console.WriteLine();

            LoanAccaunt clientOneComp = new LoanAccaunt("Georgi Tapanchev", 1200, 8, false);
            clientOneComp.Withdraw(0);
            clientOneComp.Deposit(200);
            clientOneComp.RateCalculator(14);

            Console.WriteLine();
        }
    }
}
