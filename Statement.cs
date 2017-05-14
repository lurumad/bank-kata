using System;
using System.Collections.Generic;

public class Statement
{
    public static List<StatementLine> statements = new List<StatementLine>();

    public void AddLine(DateTime date, Amount amount, Amount balance)
    {
        statements.Add(StatementLine.New(date, amount, balance));
    }
}