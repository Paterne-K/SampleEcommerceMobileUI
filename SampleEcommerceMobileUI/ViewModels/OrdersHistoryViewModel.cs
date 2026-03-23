using System.Collections.ObjectModel;
using System.Windows.Input;
using SampleEcommerceMobileUI.Models;
using SampleEcommerceMobileUI.Services;

namespace SampleEcommerceMobileUI.ViewModels;

/// <summary>
/// ViewModel for the Orders History page.
/// </summary>
public class OrdersHistoryViewModel : BaseViewModel
{
    private readonly MockDataService _dataService;

    public ObservableCollection<Order> Orders { get; } = new();
    public bool HasOrders => Orders.Count > 0;

    public ICommand GoBackCommand { get; }

    public OrdersHistoryViewModel(MockDataService dataService)
    {
        _dataService = dataService;
        Title = "My Orders";
        GoBackCommand = new Command(async () => await Shell.Current.GoToAsync(".."));
        LoadOrders();
    }

    private void LoadOrders()
    {
        Orders.Clear();
        foreach (var order in _dataService.GetOrderHistory())
            Orders.Add(order);
    }
}
