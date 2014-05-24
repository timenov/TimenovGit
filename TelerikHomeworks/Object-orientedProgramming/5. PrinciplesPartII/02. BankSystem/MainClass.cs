using System;

namespace _02.BankSystem
{
    class MainClass
    {
        static void Main()
        {
            Account[] accounts = new Account[] { new LoanAccount(Customer.Individual, 234.0M, 0.04M),
                                                    new LoanAccount(Customer.Company, 4563.23M, 0.06M),
                                                    new DepositAccount(Customer.Company, 4563.23M, 0.05M),
                                                    new DepositAccount(Customer.Individual, 463.23M, 0.0621M),
                                                    new MortgageAccount(Customer.Individual, 56000.0M, 0.0042M),
                                                    new MortgageAccount(Customer.Company, 156000.0M, 0.0032M) };

            foreach (var account in accounts)
            {
                Console.WriteLine("Account: {0}\nBalance: {1}\nInterest(for 4 mounths): {2:F2}", account.GetType().Name, account.Balance, account.CalculateInterest(4));
                Console.WriteLine(new string('*', 40));
            }
        }
    }
}
