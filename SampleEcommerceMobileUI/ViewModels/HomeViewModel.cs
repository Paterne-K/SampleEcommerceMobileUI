using System.Collections.ObjectModel;
using System.Windows.Input;
using SampleEcommerceMobileUI.Models;
using SampleEcommerceMobileUI.Services;

namespace SampleEcommerceMobileUI.ViewModels;

/// <summary>
/// ViewModel for the Home page. Loads featured products, categories, and promotions.
/// </summary>
public class HomeViewModel : BaseViewModel
{
    private readonly MockDataService _dataService;

    public ObservableCollection<Product> FeaturedProducts { get; } = new();
    public ObservableCollection<Product> NewArrivals { get; } = new();
    public ObservableCollection<Category> Categories { get; } = new();
    public ObservableCollection<Promotion> Promotions { get; } = new();

    public ICommand LoadDataCommand { get; }
    public ICommand NavigateToProductCommand { get; }
    public ICommand NavigateToCategoryCommand { get; }
    public ICommand SearchCommand { get; }

    public HomeViewModel(MockDataService dataService)
    {
        _dataService = dataService;
        Title = "CamShop";
        LoadDataCommand = new Command(LoadData);
        NavigateToProductCommand = new Command<Product>(async (p) => await NavigateToProduct(p));
        NavigateToCategoryCommand = new Command<Category>(async (c) => await NavigateToCategory(c));
        SearchCommand = new Command(async () => await Search());
        LoadData();
    }

    private void LoadData()
    {
        if (IsBusy) return;
        IsBusy = true;

        FeaturedProducts.Clear();
        NewArrivals.Clear();
        Categories.Clear();
        Promotions.Clear();

        foreach (var product in _dataService.GetFeaturedProducts())
            FeaturedProducts.Add(product);

        foreach (var product in _dataService.GetNewArrivals())
            NewArrivals.Add(product);

        foreach (var category in _dataService.GetCategories().Take(4))
            Categories.Add(category);

        foreach (var promo in _dataService.GetPromotions())
            Promotions.Add(promo);

        IsBusy = false;
    }

    private async Task NavigateToProduct(Product product)
    {
        if (product == null) return;
        await Shell.Current.GoToAsync($"productdetails?productId={product.Id}");
    }

    private async Task NavigateToCategory(Category category)
    {
        if (category == null) return;
        await Shell.Current.GoToAsync($"productlist?category={Uri.EscapeDataString(category.Name)}");
    }

    private async Task Search()
    {
        await Shell.Current.GoToAsync("productlist");
    }
}
