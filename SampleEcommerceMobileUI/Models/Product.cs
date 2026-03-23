namespace SampleEcommerceMobileUI.Models;

/// <summary>
/// Represents a product in the catalog.
/// </summary>
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public double Rating { get; set; }
    public int ReviewCount { get; set; }
    public bool IsFavorite { get; set; }
    public bool IsPopular { get; set; }
    public bool IsNew { get; set; }
    public List<string> Sizes { get; set; } = new();
    public List<string> Colors { get; set; } = new();
    public string FormattedPrice => $"{Price:N0} FCFA";
}
