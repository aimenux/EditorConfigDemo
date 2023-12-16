namespace App;

/// <summary>
/// [Prefer "readonly"]
/// </summary>
public class CsharpStylePreferReadonlyRule
{
    private readonly int _month = DateTime.Now.Month;
    private static readonly int Year = DateTime.Now.Year;

    public void Example()
    {
        Console.WriteLine($"Month is {_month}");
        Console.WriteLine($"Year is {Year}");
    }
}
