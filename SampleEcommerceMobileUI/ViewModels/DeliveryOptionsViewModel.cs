using System.Collections.ObjectModel;
using System.Windows.Input;
using SampleEcommerceMobileUI.Models;
using SampleEcommerceMobileUI.Services;

namespace SampleEcommerceMobileUI.ViewModels;

/// <summary>
/// ViewModel for the Delivery Options page.
/// </summary>
public class DeliveryOptionsViewModel : BaseViewModel
{
    private readonly MockDataService _dataService;
    private DeliveryOption? _selectedOption;

    public ObservableCollection<DeliveryOption> DeliveryOptions { get; } = new();

    public DeliveryOption? SelectedOption
    {
        get => _selectedOption;
        set => SetProperty(ref _selectedOption, value);
    }

    public ICommand SelectOptionCommand { get; }
    public ICommand ContinueCommand { get; }
    public ICommand GoBackCommand { get; }

    public DeliveryOptionsViewModel(MockDataService dataService)
    {
        _dataService = dataService;
        Title = "Delivery Options";
        SelectOptionCommand = new Command<DeliveryOption>(SelectOption);
        ContinueCommand = new Command(async () => await Continue());
        GoBackCommand = new Command(async () => await Shell.Current.GoToAsync(".."));
        LoadOptions();
    }

    private void LoadOptions()
    {
        DeliveryOptions.Clear();
        foreach (var option in _dataService.GetDeliveryOptions())
        {
            DeliveryOptions.Add(option);
            if (option.Id == 1)
                SelectedOption = option;
        }
    }

    private void SelectOption(DeliveryOption? option)
    {
        if (option == null) return;
        SelectedOption = option;
    }

    private async Task Continue()
    {
        if (SelectedOption == null)
        {
            await Shell.Current.DisplayAlert("Error", "Please select a delivery option.", "OK");
            return;
        }
        await Shell.Current.GoToAsync("payment");
    }
}
