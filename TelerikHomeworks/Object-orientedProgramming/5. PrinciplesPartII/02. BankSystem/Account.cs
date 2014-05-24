using System;

namespace _02.BankSystem
{
    abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                if (value > 0)
                {
                    this.balance = value;
                }
                else
                {
                    throw new ArgumentException("The value must be greater than zero");
                }
            }
        }
        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value >= 0)
                {
                    this.interestRate = value;
                }
                else
                {
                    throw new ArgumentException("The interest rate can not be negative");
                }
            }
        }

        public virtual decimal CalculateInterest(int period)
        {
            if (period > 0)
            {
                return this.InterestRate * period * this.Balance;
            }
            else
            {
                return this.InterestRate * this.Balance;
            }
        }
    }
}
