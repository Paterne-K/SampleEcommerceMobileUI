using System.Collections.ObjectModel;
using System.Windows.Input;
using SampleEcommerceMobileUI.Models;
using SampleEcommerceMobileUI.Services;

namespace SampleEcommerceMobileUI.ViewModels;

/// <summary>
/// ViewModel for the Product List page. Displays products filtered by category.
/// </summary>
[QueryProperty(nameof(CategoryName), "category")]
public class ProductListViewModel : BaseViewModel
{
    private readonly MockDataService _dataService;
    private string _categoryName = string.Empty;

    public ObservableCollection<Product> Products { get; } = new();

    public string CategoryName
    {
        get => _categoryName;
        set
        {
            SetProperty(ref _categoryName, value);
            Title = value;
            LoadProducts();
        }
    }

    public ICommand NavigateToProductCommand { get; }
    public ICommand GoBackCommand { get; }

    public ProductListViewModel(MockDataService dataService)
    {
        _dataService = dataService;
        Title = "Products";
        NavigateToProductCommand = new Command<Product>(async (p) => await NavigateToProduct(p));
        GoBackCommand = new Command(async () => await Shell.Current.GoToAsync(".."));
    }

    private void LoadProducts()
    {
        Products.Clear();
        var products = string.IsNullOrEmpty(CategoryName)
            ? _dataService.GetProducts()
            : _dataService.GetProductsByCategory(CategoryName);

        foreach (var product in products)
            Products.Add(product);
    }

    private async Task NavigateToProduct(Product product)
    {
        if (product == null) return;
        await Shell.Current.GoToAsync($"productdetails?productId={product.Id}");
    }
}
