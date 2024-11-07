namespace MoneyExtension;

public static class Money
{
    public static int ToCents(this decimal amount)
    {
        if(amount <= 0) return 0;
        
        var value = amount.ToString("N2")
            .Replace(",", "")
            .Replace(".", "");
        
        if(string.IsNullOrWhiteSpace(value)) return 0;
        
        int.TryParse(value, out var cents);
        return cents;
    }

    public static string ToFormatedValue(this decimal amount)
    {
        if(amount <= 0) return 0.ToString("C");
        
        return amount.ToString("C");
    }
}