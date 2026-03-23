using System.Windows.Input;
using SampleEcommerceMobileUI.Services;

namespace SampleEcommerceMobileUI.ViewModels;

/// <summary>
/// ViewModel for the Order Summary page.
/// </summary>
public class OrderSummaryViewModel : BaseViewModel
{
    private readonly MockDataService _dataService;

    public string ShippingAddress { get; set; } = "Rue de la Joie, Akwa, Douala, Cameroon";
    public string DeliveryMethod { get; set; } = "Standard Delivery (3-5 days)";
    public string PaymentMethod { get; set; } = "MTN Mobile Money";
    public string FormattedSubtotal { get; set; } = "47,000 FCFA";
    public string FormattedDelivery { get; set; } = "2,000 FCFA";
    public string FormattedTotal { get; set; } = "49,000 FCFA";

    public ICommand PlaceOrderCommand { get; }
    public ICommand GoBackCommand { get; }

    public OrderSummaryViewModel(MockDataService dataService)
    {
        _dataService = dataService;
        Title = "Order Summary";
        PlaceOrderCommand = new Command(async () => await PlaceOrder());
        GoBackCommand = new Command(async () => await Shell.Current.GoToAsync(".."));
    }

    private async Task PlaceOrder()
    {
        IsBusy = true;
        // Simulate order processing
        await Task.Delay(1500);
        IsBusy = false;
        await Shell.Current.GoToAsync("ordersuccess");
    }
}
