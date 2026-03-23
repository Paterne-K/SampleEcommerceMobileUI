namespace SampleEcommerceMobileUI.Models;

/// <summary>
/// Represents a delivery/shipping option.
/// </summary>
public class DeliveryOption
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string EstimatedDays { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string FormattedPrice => Price == 0 ? "Free" : $"{Price:N0} FCFA";
}
