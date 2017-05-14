using System;

public class AccountStatement
{
    private DateTime date;
    private Amount amount;
    private Amount balance;

    public static AccountStatement New(DateTime date, Amount amount, Amount balance)
    {
        return new AccountStatement(date, amount, balance);
    }

    private AccountStatement(DateTime date, Amount amount, Amount balance)
    {
        this.date = date;
        this.amount = amount;
        this.balance = balance;
    }
}