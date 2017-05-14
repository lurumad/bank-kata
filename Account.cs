using System;
using System.Collections.Generic;
using System.IO;

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

        public void PrintStatements(TextWriter printer)
        {
            printer.Write("date || credit || debit || balance");
        }
    }
}