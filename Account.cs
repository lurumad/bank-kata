using System;
using System.Collections.Generic;
using System.IO;

namespace Bank
{
    public class Account
    {
        public decimal balance;
        private Statement statement = new Statement();

        public static Account New()
        {
            return new Account(Amount.New(0));
        }

        public Account(Amount amount)
        {
            balance = amount;
        }

        public void Deposit(DateTime date, Amount amount)
        {
            balance += amount;
            statement.AddLine(date, amount, Amount.New(balance));            
        }

        public void Withdrawal(DateTime date, Amount amount)
        {
            balance += amount.Negative();
            statement.AddLine(date, amount.Negative(), Amount.New(balance));
        }

        public void PrintStatements(TextWriter printer)
        {
            statement.PrintStatements(printer);
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}