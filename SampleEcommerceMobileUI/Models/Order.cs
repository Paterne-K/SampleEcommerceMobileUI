namespace SampleEcommerceMobileUI.Models;

/// <summary>
/// Represents a completed order.
/// </summary>
public class Order
{
    public string OrderId { get; set; } = string.Empty;
    public DateTime OrderDate { get; set; }
    public List<CartItem> Items { get; set; } = new();
    public decimal TotalAmount { get; set; }
    public string Status { get; set; } = "Processing";
    public string ShippingAddress { get; set; } = string.Empty;
    public string PaymentMethod { get; set; } = string.Empty;
    public string FormattedTotal => $"{TotalAmount:N0} FCFA";
    public string FormattedDate => OrderDate.ToString("dd MMM yyyy");
    public string StatusColor => Status switch
    {
        "Delivered" => "#10B981",
        "Shipped" => "#3B82F6",
        "Processing" => "#F59E0B",
        "Cancelled" => "#EF4444",
        _ => "#6B7280"
    };
}
