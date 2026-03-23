using System.Collections.ObjectModel;
using System.Windows.Input;
using SampleEcommerceMobileUI.Models;
using SampleEcommerceMobileUI.Services;

namespace SampleEcommerceMobileUI.ViewModels;

/// <summary>
/// ViewModel for the Shipping Address page.
/// </summary>
public class ShippingAddressViewModel : BaseViewModel
{
    private readonly MockDataService _dataService;
    private ShippingAddress? _selectedAddress;

    public ObservableCollection<ShippingAddress> Addresses { get; } = new();

    public ShippingAddress? SelectedAddress
    {
        get => _selectedAddress;
        set => SetProperty(ref _selectedAddress, value);
    }

    public ICommand SelectAddressCommand { get; }
    public ICommand ContinueCommand { get; }
    public ICommand GoBackCommand { get; }

    public ShippingAddressViewModel(MockDataService dataService)
    {
        _dataService = dataService;
        Title = "Shipping Address";
        SelectAddressCommand = new Command<ShippingAddress>(SelectAddress);
        ContinueCommand = new Command(async () => await Continue());
        GoBackCommand = new Command(async () => await Shell.Current.GoToAsync(".."));
        LoadAddresses();
    }

    private void LoadAddresses()
    {
        Addresses.Clear();
        foreach (var address in _dataService.GetSavedAddresses())
        {
            Addresses.Add(address);
            if (address.IsDefault)
                SelectedAddress = address;
        }
    }

    private void SelectAddress(ShippingAddress? address)
    {
        if (address == null) return;
        SelectedAddress = address;
    }

    private async Task Continue()
    {
        if (SelectedAddress == null)
        {
            await Shell.Current.DisplayAlert("Error", "Please select a shipping address.", "OK");
            return;
        }
        await Shell.Current.GoToAsync("deliveryoptions");
    }
}
