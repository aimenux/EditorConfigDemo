namespace App;

/// <summary>
/// [Prefer "var"]
/// </summary>
public static class CsharpStylePreferVarRule
{
    public static void Example()
    {
        // csharp_style_var_when_type_is_apparent = true
        var customer = new Customer(true);

        // csharp_style_var_for_built_in_types = true
        var isActive = customer.IsActive;
    }

    private record Customer(bool IsActive);
}
