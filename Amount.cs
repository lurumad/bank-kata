public class Amount
{
    private decimal value;

    public Amount(decimal value)
    {
        this.value = value;
    }

    public static Amount New(decimal value)
    {
        return new Amount(value);
    }

    public Amount Negative()
    {
        return new Amount(-value);
    }

    public Amount Positive()
    {
        return new Amount(value*-1);
    }

    public static implicit operator decimal(Amount amount)
    {
        return amount.value;
    }

    public static explicit operator Amount(decimal value)
    {
        return New(value);
    }

    public override string ToString()
    {
        return value.ToString("0.00");
    }
}