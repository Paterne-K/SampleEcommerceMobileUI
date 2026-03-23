namespace SampleEcommerceMobileUI.Models;

/// <summary>
/// Represents an item in the shopping cart.
/// </summary>
public class CartItem : INotifyPropertyChanged
{
    private int _quantity = 1;

    public int Id { get; set; }
    public Product Product { get; set; } = new();
    public string SelectedSize { get; set; } = string.Empty;
    public string SelectedColor { get; set; } = string.Empty;

    public int Quantity
    {
        get => _quantity;
        set
        {
            if (_quantity != value)
            {
                _quantity = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TotalPrice));
                OnPropertyChanged(nameof(FormattedTotalPrice));
            }
        }
    }

    public decimal TotalPrice => Product.Price * Quantity;
    public string FormattedTotalPrice => $"{TotalPrice:N0} FCFA";

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
