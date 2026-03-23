using SampleEcommerceMobileUI.ViewModels;

namespace SampleEcommerceMobileUI.Views.Checkout;

/// <summary>
/// Shipping address selection page in the checkout flow.
/// </summary>
public partial class ShippingAddressPage : ContentPage
{
    public ShippingAddressPage(ShippingAddressViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
