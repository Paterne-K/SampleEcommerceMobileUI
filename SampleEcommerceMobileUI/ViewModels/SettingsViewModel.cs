using System.Windows.Input;

namespace SampleEcommerceMobileUI.ViewModels;

/// <summary>
/// ViewModel for the Settings page.
/// </summary>
public class SettingsViewModel : BaseViewModel
{
    private bool _notificationsEnabled = true;
    private bool _darkModeEnabled;
    private string _selectedLanguage = "English";

    public bool NotificationsEnabled { get => _notificationsEnabled; set => SetProperty(ref _notificationsEnabled, value); }
    public bool DarkModeEnabled { get => _darkModeEnabled; set => SetProperty(ref _darkModeEnabled, value); }
    public string SelectedLanguage { get => _selectedLanguage; set => SetProperty(ref _selectedLanguage, value); }

    public ICommand GoBackCommand { get; }
    public ICommand SaveCommand { get; }

    public SettingsViewModel()
    {
        Title = "Settings";
        GoBackCommand = new Command(async () => await Shell.Current.GoToAsync(".."));
        SaveCommand = new Command(async () => await Shell.Current.DisplayAlert("Settings", "Settings saved successfully!", "OK"));
    }
}
