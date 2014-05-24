using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    class DepositAccount : Account, IDepositable, IDrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interest;
        }

        public override decimal CalculateInterest(int period)
        {
            if (this.Balance > 1000)
            {
                return this.InterestRate * period * this.Balance;
            }
            else
            {
                return this.Balance * this.InterestRate;
            }
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= this.Balance)
            {
                this.Balance -= amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException(string.Format("The amount can not be greater than balance ({0})", this.Balance));
            }
        }
    }
}
