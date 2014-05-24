using System;

namespace _02.BankSystem
{
    class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interest;
        }

        public override decimal CalculateInterest(int period)
        {
            if (this.Customer == Customer.Company)
            {
                if (period > 12)
                {
                    return this.InterestRate * (period - 12) * this.Balance + (this.InterestRate * 12 * this.Balance) / 2;
                }
                else
                {
                    return (this.InterestRate * period * this.Balance) / 2;
                }
            }
            else if (this.Customer == Customer.Individual && period > 6)
            {
                return this.InterestRate * (period - 6) * this.Balance;
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
