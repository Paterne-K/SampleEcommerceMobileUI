namespace SampleEcommerceMobileUI.Models;

/// <summary>
/// Represents a promotional banner.
/// </summary>
public class Promotion
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Subtitle { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string BackgroundColor { get; set; } = "#FF6B35";
    public decimal DiscountPercent { get; set; }
}
