using SampleEcommerceMobileUI.Models;
using SampleEcommerceMobileUI.ViewModels;

namespace SampleEcommerceMobileUI.Views.Main;

/// <summary>
/// Home page displaying promotions, categories, featured products and new arrivals.
/// </summary>
public partial class HomePage : ContentPage
{
    public HomePage(HomeViewModel viewModel)
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

    private async void OnSeeAllCategoriesTapped(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//categories");
    }

    private async void OnSeeAllPopularTapped(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("productlist");
    }
}
