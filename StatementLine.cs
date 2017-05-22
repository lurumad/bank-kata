using System;
using System.IO;

public class StatementLine
{
    private const string Line = "{0:dd/MM/yyyy} || {1} || {2} || {3}";
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

    public void Print(TextWriter printer)
    {
        if (amount < 0)
        {
            printer.WriteLine(Line, date, String.Empty, amount.Positive(), balance);
        }
        else
        {
            printer.WriteLine(Line, date, amount, String.Empty, balance);
        }
    }
}