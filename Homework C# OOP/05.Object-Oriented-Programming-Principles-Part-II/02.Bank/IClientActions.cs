using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank
{
    interface IClientActions
    {
        void Deposit(double inputDeposit);
        void Withdraw(double inputWithdraw);
        void RateCalculator(int inputTime);
    }
}
