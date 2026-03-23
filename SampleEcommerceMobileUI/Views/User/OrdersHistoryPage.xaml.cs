namespace SampleEcommerceMobileUI.Views.User;

/// <summary>
/// Orders history page showing past orders and their status.
/// </summary>
public partial class OrdersHistoryPage : ContentPage
{
    public OrdersHistoryPage(OrdersHistoryViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
