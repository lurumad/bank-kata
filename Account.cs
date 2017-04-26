using System;

namespace Bank
{
    public class Account
    {
        public decimal Balance { get; set; }

        public Account(decimal amount)
        {

        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}