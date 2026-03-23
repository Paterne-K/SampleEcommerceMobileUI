using SampleEcommerceMobileUI.ViewModels;

namespace SampleEcommerceMobileUI.Views.Main;

/// <summary>
/// Cart page displaying items in the shopping cart with totals.
/// </summary>
public partial class CartPage : ContentPage
{
    public CartPage(CartViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
