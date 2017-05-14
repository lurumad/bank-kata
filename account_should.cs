using System;
using System.IO;
using FluentAssertions;
using Xunit;

namespace Bank
{
    public class account_should
    {
        [Fact]
        public void allow_to_make_a_deposit()
        {
            var account = Account.New();
            account.Deposit(DateTime.UtcNow, Amount.New(1000));
            account.Balance.Should().Be(1000);
        }

        [Fact]
        public void allow_to_make_a_withdrawal()
        {
            var account = Account.New();
            account.Withdrawal(DateTime.UtcNow, Amount.New(1000));
            account.Balance.Should().Be(-1000);
        }

        [Fact]
        public void should_be_print_her_statements()
        {
            var printer = new StringWriter();
            Console.SetOut(printer);
            var account = Account.New();
            account.Deposit(DateTime.Parse("10-01-2012"), Amount.New(1000));
            account.Deposit(DateTime.Parse("13-01-2012"), Amount.New(2000));
            account.Withdrawal(DateTime.Parse("14-01-2012"), Amount.New(500));
            account.PrintStatements(Console.Out);
            printer.ToString().Should().Be(@"date || credit || debit || balance\n14 / 01 / 2012 || || 500.00 || 2500.00\n13 / 01 / 2012 || 2000.00 || || 3000.00\n10 / 01 / 2012 || 1000.00 || || 1000.00");
        }
    }
}
