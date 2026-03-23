using System.Collections.ObjectModel;
using System.Windows.Input;
using SampleEcommerceMobileUI.Models;
using SampleEcommerceMobileUI.Services;

namespace SampleEcommerceMobileUI.ViewModels;

/// <summary>
/// ViewModel for the Payment page.
/// </summary>
public class PaymentViewModel : BaseViewModel
{
    private readonly MockDataService _dataService;
    private PaymentMethod? _selectedMethod;

    public ObservableCollection<PaymentMethod> PaymentMethods { get; } = new();

    public PaymentMethod? SelectedMethod
    {
        get => _selectedMethod;
        set => SetProperty(ref _selectedMethod, value);
    }

    public ICommand SelectMethodCommand { get; }
    public ICommand ContinueCommand { get; }
    public ICommand GoBackCommand { get; }

    public PaymentViewModel(MockDataService dataService)
    {
        _dataService = dataService;
        Title = "Payment";
        SelectMethodCommand = new Command<PaymentMethod>(SelectMethod);
        ContinueCommand = new Command(async () => await Continue());
        GoBackCommand = new Command(async () => await Shell.Current.GoToAsync(".."));
        LoadMethods();
    }

    private void LoadMethods()
    {
        PaymentMethods.Clear();
        foreach (var method in _dataService.GetPaymentMethods())
        {
            PaymentMethods.Add(method);
            if (method.Id == 1)
                SelectedMethod = method;
        }
    }

    private void SelectMethod(PaymentMethod? method)
    {
        if (method == null) return;
        SelectedMethod = method;
    }

    private async Task Continue()
    {
        if (SelectedMethod == null)
        {
            await Shell.Current.DisplayAlert("Error", "Please select a payment method.", "OK");
            return;
        }
        await Shell.Current.GoToAsync("ordersummary");
    }
}
