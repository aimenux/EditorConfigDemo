namespace App;

/// <summary>
/// [Prefer "braces"]
/// </summary>
public static class CsharpStylePreferBracesRule
{
    public static void Example()
    {
        var year = DateTime.Now.Year;
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine($"Year {year} is leap");
        }
    }
}
