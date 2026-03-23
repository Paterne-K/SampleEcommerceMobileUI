using SampleEcommerceMobileUI.Models;
using SampleEcommerceMobileUI.ViewModels;

namespace SampleEcommerceMobileUI.Views.Main;

/// <summary>
/// Categories page displaying all product categories in a grid.
/// </summary>
public partial class CategoriesPage : ContentPage
{
    public CategoriesPage(CategoriesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void OnCategorySelected(object? sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Category category)
        {
            await Shell.Current.GoToAsync($"productlist?category={Uri.EscapeDataString(category.Name)}");
            ((CollectionView)sender!).SelectedItem = null;
        }
    }
}
