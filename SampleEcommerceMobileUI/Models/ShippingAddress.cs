namespace SampleEcommerceMobileUI.Models;

/// <summary>
/// Represents a shipping address.
/// </summary>
public class ShippingAddress
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string Country { get; set; } = "Cameroon";
    public bool IsDefault { get; set; }
    public string FullAddress => $"{Street}, {City}, {Region}, {Country}";
}
