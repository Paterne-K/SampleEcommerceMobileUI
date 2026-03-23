using SampleEcommerceMobileUI.Models;
using SampleEcommerceMobileUI.ViewModels;

namespace SampleEcommerceMobileUI.Views.Main;

/// <summary>
/// Product list page showing products in a grid, optionally filtered by category.
/// </summary>
public partial class ProductListPage : ContentPage
{
    public ProductListPage(ProductListViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void OnProductSelected(object? sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Product product)
        {
            await Shell.Current.GoToAsync($"productdetails?productId={product.Id}");
            ((CollectionView)sender!).SelectedItem = null;
        }
    }
}
