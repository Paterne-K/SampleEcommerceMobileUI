namespace SampleEcommerceMobileUI.Views.Checkout;

/// <summary>
/// Order success confirmation page displayed after successful order placement.
/// </summary>
public partial class OrderSuccessPage : ContentPage
{
    public OrderSuccessPage()
    {
        InitializeComponent();
    }

    private async void OnContinueShoppingClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//home");
    }

    private async void OnViewOrdersClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//profile");
    }
}
