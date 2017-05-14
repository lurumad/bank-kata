using System;
using System.Collections.Generic;
using System.IO;

public class Statement
{
    private const string Header = "date || credit || debit || balance";
    public static LinkedList<StatementLine> statements = new LinkedList<StatementLine>();

    public void AddLine(DateTime date, Amount amount, Amount balance)
    {
        statements.AddFirst(StatementLine.New(date, amount, balance));
    }

    public void PrintStatements(TextWriter printer)
    {
        foreach(var statement in statements)
        {
            statement.Print(printer);
        }
    }
}