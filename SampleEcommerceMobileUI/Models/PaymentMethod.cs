namespace SampleEcommerceMobileUI.Models;

/// <summary>
/// Represents a payment method option.
/// </summary>
public class PaymentMethod
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
}
