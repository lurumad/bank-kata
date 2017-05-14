using System;
using System.Collections.Generic;

namespace Bank
{
    public class Account
    {
        public decimal Balance { get; set; }
        private List<AccountStatement> statements = new List<AccountStatement>();

        public static Account New()
        {
            return new Account(Amount.New(0));
        }

        public Account(Amount amount)
        {
            Balance = amount;
        }

        public void Deposit(Amount amount)
        {
            Balance += amount;
            statements.Add(AccountStatement.New(DateTime.UtcNow, amount, Amount.New(Balance)));            
        }

        public void Withdrawal(Amount amount)
        {
            Balance += amount.Negative();
            statements.Add(AccountStatement.New(DateTime.UtcNow, amount.Negative(), Amount.New(Balance)));
        }
    }
}