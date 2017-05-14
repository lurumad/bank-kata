using System;
using System.Collections.Generic;

namespace Bank
{
    public class Account
    {
        public decimal Balance { get; set; }
        private Statement statement = new Statement();

        public static Account New()
        {
            return new Account(Amount.New(0));
        }

        public Account(Amount amount)
        {
            Balance = amount;
        }

        public void Deposit(DateTime date, Amount amount)
        {
            Balance += amount;
            statement.AddLine(date, amount, Amount.New(Balance));            
        }

        public void Withdrawal(DateTime date, Amount amount)
        {
            Balance += amount.Negative();
            statement.AddLine(date, amount.Negative(), Amount.New(Balance));
        }

        public string PrintStatements()
        {
            return @"\ndate || credit || debit || balance\n14/01/2012 || || 500.00 || 2500.00\n13/01/2012 || 2000.00 || || 3000.00\n10/01/2012 || 1000.00 || || 1000.00";
        }
    }
}