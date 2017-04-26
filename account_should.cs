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
            var account = new Account(0);
            account.Deposit(1000);
            account.Balance.Should().Be(1000);
        }
    }
}
