using System;

namespace _02.BankSystem
{
    class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interest;
        }

        public override decimal CalculateInterest(int period)
        {
            if (this.Customer == Customer.Company && period > 2)
            {
                return this.InterestRate * (period - 2) * this.Balance;
            }
            else if (this.Customer == Customer.Individual && period > 3)
            {
                return this.InterestRate * (period - 3) * this.Balance;
            }
            else
            {
                return this.Balance * this.InterestRate;
            }
        }

        public void Deposit(decimal amount)
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
