using System;

namespace Bank
{
    public class Account
    {
        public decimal Balance { get; set; }

        public static Account Create(decimal amount)
        {
            return new Account(amount);
        }

        public Account(decimal amount)
        {

        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdrawal(decimal amount)
        {
            Balance -= amount;
        }
    }
}