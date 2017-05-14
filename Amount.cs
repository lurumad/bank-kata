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

    public static implicit operator decimal(Amount amount)
    {
        return amount.value;
    }

    public static explicit operator Amount(decimal value)
    {
        return new Amount(value);
    }
}