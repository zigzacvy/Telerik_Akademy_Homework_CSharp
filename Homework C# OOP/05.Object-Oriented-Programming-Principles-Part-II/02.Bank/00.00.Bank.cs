using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank
{
    public class Bank
    {
        public string custName { get; set; }
        public double balance { get; set; }
        public double interestRate { get; set; }

        public Bank(string inputName, double inputBalance, double inputRate)
        {
            this.custName = inputName;
            this.balance = inputBalance;
            this.interestRate = inputRate;
        }
    }
}
