using SampleEcommerceMobileUI.ViewModels;

namespace SampleEcommerceMobileUI.Views.Checkout;

/// <summary>
/// Order summary page showing all order details before placing the order.
/// </summary>
public partial class OrderSummaryPage : ContentPage
{
    public OrderSummaryPage(OrderSummaryViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
