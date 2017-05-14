using System;

public class StatementLine
{
    private DateTime date;
    private Amount amount;
    private Amount balance;

    public static StatementLine New(DateTime date, Amount amount, Amount balance)
    {
        return new StatementLine(date, amount, balance);
    }

    private StatementLine(DateTime date, Amount amount, Amount balance)
    {
        this.date = date;
        this.amount = amount;
        this.balance = balance;
    }
}