using System.Collections.ObjectModel;
using System.Windows.Input;
using SampleEcommerceMobileUI.Models;
using SampleEcommerceMobileUI.Services;

namespace SampleEcommerceMobileUI.ViewModels;

/// <summary>
/// ViewModel for the Cart page. Manages cart items and totals.
/// </summary>
public class CartViewModel : BaseViewModel
{
    private readonly MockDataService _dataService;

    public ObservableCollection<CartItem> CartItems { get; } = new();

    public decimal Subtotal => CartItems.Sum(i => i.TotalPrice);
    public decimal DeliveryFee => CartItems.Count > 0 ? 2000 : 0;
    public decimal Total => Subtotal + DeliveryFee;
    public string FormattedSubtotal => $"{Subtotal:N0} FCFA";
    public string FormattedDeliveryFee => DeliveryFee == 0 ? "Free" : $"{DeliveryFee:N0} FCFA";
    public string FormattedTotal => $"{Total:N0} FCFA";
    public bool IsCartEmpty => CartItems.Count == 0;
    public bool HasItems => CartItems.Count > 0;

    public ICommand RemoveItemCommand { get; }
    public ICommand IncrementCommand { get; }
    public ICommand DecrementCommand { get; }
    public ICommand CheckoutCommand { get; }
    public ICommand ContinueShoppingCommand { get; }

    public CartViewModel(MockDataService dataService)
    {
        _dataService = dataService;
        Title = "My Cart";
        RemoveItemCommand = new Command<CartItem>(RemoveItem);
        IncrementCommand = new Command<CartItem>(IncrementItem);
        DecrementCommand = new Command<CartItem>(DecrementItem);
        CheckoutCommand = new Command(async () => await Checkout());
        ContinueShoppingCommand = new Command(async () => await Shell.Current.GoToAsync("//home"));
        LoadMockCartItems();
    }

    private void LoadMockCartItems()
    {
        var products = _dataService.GetProducts();
        CartItems.Add(new CartItem { Id = 1, Product = products[0], Quantity = 1, SelectedSize = "L", SelectedColor = "Blue" });
        CartItems.Add(new CartItem { Id = 2, Product = products[6], Quantity = 1, SelectedSize = "42", SelectedColor = "White" });
        CartItems.Add(new CartItem { Id = 3, Product = products[13], Quantity = 2, SelectedColor = "Multi" });
        UpdateTotals();
    }

    private void RemoveItem(CartItem? item)
    {
        if (item == null) return;
        CartItems.Remove(item);
        UpdateTotals();
    }

    private void IncrementItem(CartItem? item)
    {
        if (item == null) return;
        item.Quantity++;
        UpdateTotals();
    }

    private void DecrementItem(CartItem? item)
    {
        if (item == null || item.Quantity <= 1) return;
        item.Quantity--;
        UpdateTotals();
    }

    private void UpdateTotals()
    {
        OnPropertyChanged(nameof(Subtotal));
        OnPropertyChanged(nameof(DeliveryFee));
        OnPropertyChanged(nameof(Total));
        OnPropertyChanged(nameof(FormattedSubtotal));
        OnPropertyChanged(nameof(FormattedDeliveryFee));
        OnPropertyChanged(nameof(FormattedTotal));
        OnPropertyChanged(nameof(IsCartEmpty));
        OnPropertyChanged(nameof(HasItems));
    }

    private async Task Checkout()
    {
        if (CartItems.Count == 0) return;
        await Shell.Current.GoToAsync("shippingaddress");
    }
}
