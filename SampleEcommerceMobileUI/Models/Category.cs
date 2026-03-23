namespace SampleEcommerceMobileUI.Models;

/// <summary>
/// Represents a product category.
/// </summary>
public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public int ProductCount { get; set; }
    public string Color { get; set; } = "#FF6B35";
}
