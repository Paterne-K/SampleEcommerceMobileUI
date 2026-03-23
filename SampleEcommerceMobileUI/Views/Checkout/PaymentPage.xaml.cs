using SampleEcommerceMobileUI.ViewModels;

namespace SampleEcommerceMobileUI.Views.Checkout;

/// <summary>
/// Payment method selection page in the checkout flow.
/// </summary>
public partial class PaymentPage : ContentPage
{
    public PaymentPage(PaymentViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
