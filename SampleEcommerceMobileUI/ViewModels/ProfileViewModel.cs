using System.Windows.Input;
using SampleEcommerceMobileUI.Models;
using SampleEcommerceMobileUI.Services;

namespace SampleEcommerceMobileUI.ViewModels;

/// <summary>
/// ViewModel for the Profile page.
/// </summary>
public class ProfileViewModel : BaseViewModel
{
    private readonly MockDataService _dataService;
    private UserProfile? _user;

    public UserProfile? User
    {
        get => _user;
        set => SetProperty(ref _user, value);
    }

    public ICommand NavigateToOrdersCommand { get; }
    public ICommand NavigateToSettingsCommand { get; }
    public ICommand LogoutCommand { get; }
    public ICommand EditProfileCommand { get; }

    public ProfileViewModel(MockDataService dataService)
    {
        _dataService = dataService;
        Title = "Profile";
        User = _dataService.GetUserProfile();
        NavigateToOrdersCommand = new Command(async () => await Shell.Current.GoToAsync("ordershistory"));
        NavigateToSettingsCommand = new Command(async () => await Shell.Current.GoToAsync("settings"));
        LogoutCommand = new Command(async () => await Logout());
        EditProfileCommand = new Command(async () => await Shell.Current.DisplayAlert("Edit Profile", "Profile editing would open here.", "OK"));
    }

    private async Task Logout()
    {
        bool confirm = await Shell.Current.DisplayAlert("Logout", "Are you sure you want to logout?", "Yes", "No");
        if (confirm)
            await Shell.Current.GoToAsync("//splash");
    }
}
