using SampleEcommerceMobileUI.ViewModels;

namespace SampleEcommerceMobileUI.Views.Checkout;

/// <summary>
/// Delivery options selection page in the checkout flow.
/// </summary>
public partial class DeliveryOptionsPage : ContentPage
{
    public DeliveryOptionsPage(DeliveryOptionsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
