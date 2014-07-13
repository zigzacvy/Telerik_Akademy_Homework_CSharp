using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank
{
    public class DepositAccaunt : ClientTypes
    {
        public DepositAccaunt(string inputName, double inputBalance, double inputRate, bool inputIsInd)
            : base(inputName, inputBalance, inputRate, inputIsInd) { }

        public void Deposit(double inputDeposit)
        {
            base.balance += inputDeposit;
            Console.WriteLine("The balance on your accaunt is {0}.", base.balance);
        }

        public void Withdraw(double inputWithdraw)
        {
            if (base.balance > inputWithdraw)
            {
                base.balance -= inputWithdraw;
                Console.WriteLine("The balance on your accaunt is {0}.", base.balance);
            }
            else
            {
                throw new Exception("Not enough money!");
            }
        }

        public void RateCalculator(int inputTime)
        {
            if (base.balance > 1000)
            {
                double result = base.balance *
                    Math.Pow((1 + base.interestRate / inputTime), (inputTime * (inputTime / 12)));
                Console.WriteLine("After {0} mounts, your balance is {1} with rate of {2}.", inputTime, result, base.interestRate);
            }
            else
            {
                throw new Exception("Sorry!"); //The balance of an Deposit account couldn't be negative.
            }
        }
    }

    public class LoanAccaunt : ClientTypes
    {
        public LoanAccaunt(string inputName, double inputBalance, double inputRate, bool inputIsInd)
            : base(inputName, inputBalance, inputRate, inputIsInd) { }

        public void Deposit(double inputDeposit)
        {
            base.balance += inputDeposit;
            Console.WriteLine("The balance on your accaunt is {0}.", base.balance);
        }

        public void RateCalculator(int inputTime)
        {
            if (base.isIndividual == true && inputTime > 3)
            {
                inputTime -= 3;
                double result = base.balance *
                   Math.Pow((1 + base.interestRate / inputTime), (inputTime * (inputTime / 12)));
                Console.WriteLine("After {0} mounts, your balance is {1} with rate of {2}.", inputTime, result, base.interestRate);
            }
            else if (base.isCompagny == true && inputTime > 2)
            {
                inputTime -= 2;
                double result = base.balance *
                  Math.Pow((1 + base.interestRate / inputTime), (inputTime * (inputTime / 12)));
                Console.WriteLine("After {0} mounts, your balance is {1} with rate of {2}.", inputTime, result, base.interestRate);
            }
            else
            {
                throw new Exception("Rate calculating period isn't started yet!");
            }
        }

        public void Withdraw(double inputWithdraw)
        {
            Console.WriteLine("You can't withdraw from this accaunt.");
        }
    }

    public class Mortgage : ClientTypes
    {
        public Mortgage(string inputName, double inputBalance, double inputRate, bool inputIsInd)
            : base(inputName, inputBalance, inputRate, inputIsInd) { }

        public void Deposit(double inputDeposit)
        {
            base.balance += inputDeposit;
            Console.WriteLine("The balance on your accaunt is {0}.", base.balance);
        }

        public void RateCalculator(int inputTime)
        {
            if (base.isIndividual == true && inputTime > 6)
            {
                inputTime -= 6;
                double result = base.balance *
                   Math.Pow((1 + base.interestRate / inputTime), (inputTime * (inputTime / 12)));
                Console.WriteLine("After {0} mounts, your balance is {1} with rate of {2}.", inputTime, result, base.interestRate);
            }
            else if (base.isCompagny == true)
            {
                if (inputTime < 12)
                {
                    base.interestRate /= 2;
                    double result = base.balance *
                      Math.Pow((1 + base.interestRate / inputTime), (inputTime * (inputTime / 12)));
                    Console.WriteLine("After {0} mounts, your balance is {1} with rate of {2}.", inputTime, result, base.interestRate);
                }
                else
                {
                    base.interestRate /= 2;
                    base.balance = base.balance *
                      Math.Pow((1 + base.interestRate / 12), 12);
                    base.interestRate *= 2;
                    inputTime -= 12;
                    double result = base.balance *
                      Math.Pow((1 + base.interestRate / inputTime), (inputTime * (inputTime / 12)));
                    Console.WriteLine("After {0} mounts, your balance is {1} with rate of {2}.", inputTime, result, base.interestRate);
                }
            }
            else
            {
                throw new Exception("Rate calculating period isn't started yet!");
            }
        }

        public void Withdraw(double inputWithdraw)
        {
            Console.WriteLine("You can't withdraw from this accaunt.");
        }
    }
}
