using System;
using FluentAssertions;
using Xunit;

namespace Bank
{
    public class account_should
    {
        [Fact]
        public void allow_to_make_a_deposit()
        {
            var account = Account.Create(0);
            account.Deposit(1000);
            account.Balance.Should().Be(1000);
        }

        [Fact]
        public void allow_to_make_a_withdrawal()
        {
            var account = Account.Create(0);
            account.Withdrawal(1000);
            account.Balance.Should().Be(-1000);
        }
    }
}
