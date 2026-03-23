using SampleEcommerceMobileUI.ViewModels;

namespace SampleEcommerceMobileUI.Views.Main;

/// <summary>
/// Product details page showing full product information with add to cart.
/// </summary>
public partial class ProductDetailsPage : ContentPage
{
    public ProductDetailsPage(ProductDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
