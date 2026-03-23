using System.Windows.Input;
using SampleEcommerceMobileUI.Models;
using SampleEcommerceMobileUI.Services;

namespace SampleEcommerceMobileUI.ViewModels;

/// <summary>
/// ViewModel for the Product Details page.
/// </summary>
[QueryProperty(nameof(ProductId), "productId")]
public class ProductDetailsViewModel : BaseViewModel
{
    private readonly MockDataService _dataService;
    private Product? _product;
    private string _selectedSize = string.Empty;
    private string _selectedColor = string.Empty;
    private int _quantity = 1;
    private int _productId;

    public Product? Product
    {
        get => _product;
        set => SetProperty(ref _product, value);
    }

    public int ProductId
    {
        get => _productId;
        set
        {
            SetProperty(ref _productId, value);
            LoadProduct();
        }
    }

    public string SelectedSize
    {
        get => _selectedSize;
        set => SetProperty(ref _selectedSize, value);
    }

    public string SelectedColor
    {
        get => _selectedColor;
        set => SetProperty(ref _selectedColor, value);
    }

    public int Quantity
    {
        get => _quantity;
        set => SetProperty(ref _quantity, value);
    }

    public ICommand AddToCartCommand { get; }
    public ICommand IncrementCommand { get; }
    public ICommand DecrementCommand { get; }
    public ICommand GoBackCommand { get; }
    public ICommand ToggleFavoriteCommand { get; }

    public ProductDetailsViewModel(MockDataService dataService)
    {
        _dataService = dataService;
        AddToCartCommand = new Command(async () => await AddToCart());
        IncrementCommand = new Command(() => Quantity++);
        DecrementCommand = new Command(() => { if (Quantity > 1) Quantity--; });
        GoBackCommand = new Command(async () => await Shell.Current.GoToAsync(".."));
        ToggleFavoriteCommand = new Command(ToggleFavorite);
    }

    private void LoadProduct()
    {
        Product = _dataService.GetProductById(ProductId);
        if (Product != null)
        {
            Title = Product.Name;
            if (Product.Sizes.Count > 0) SelectedSize = Product.Sizes[0];
            if (Product.Colors.Count > 0) SelectedColor = Product.Colors[0];
        }
    }

    private async Task AddToCart()
    {
        if (Product == null) return;
        await Shell.Current.DisplayAlert("Added to Cart",
            $"{Product.Name} ({SelectedSize}, {SelectedColor}) x{Quantity} added to your cart!",
            "OK");
    }

    private void ToggleFavorite()
    {
        if (Product != null)
            Product.IsFavorite = !Product.IsFavorite;
    }
}
