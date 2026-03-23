using System.Windows.Input;

namespace SampleEcommerceMobileUI.ViewModels;

/// <summary>
/// ViewModel for the Register page.
/// </summary>
public class RegisterViewModel : BaseViewModel
{
    private string _fullName = string.Empty;
    private string _email = string.Empty;
    private string _phone = string.Empty;
    private string _password = string.Empty;
    private string _confirmPassword = string.Empty;

    public string FullName { get => _fullName; set => SetProperty(ref _fullName, value); }
    public string Email { get => _email; set => SetProperty(ref _email, value); }
    public string Phone { get => _phone; set => SetProperty(ref _phone, value); }
    public string Password { get => _password; set => SetProperty(ref _password, value); }
    public string ConfirmPassword { get => _confirmPassword; set => SetProperty(ref _confirmPassword, value); }

    public ICommand RegisterCommand { get; }
    public ICommand NavigateToLoginCommand { get; }

    public RegisterViewModel()
    {
        Title = "Create Account";
        RegisterCommand = new Command(async () => await Register());
        NavigateToLoginCommand = new Command(async () => await Shell.Current.GoToAsync(".."));
    }

    private async Task Register()
    {
        if (string.IsNullOrWhiteSpace(FullName) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
        {
            await Shell.Current.DisplayAlert("Error", "Please fill in all required fields.", "OK");
            return;
        }
        if (Password != ConfirmPassword)
        {
            await Shell.Current.DisplayAlert("Error", "Passwords do not match.", "OK");
            return;
        }
        // Navigate to OTP verification
        await Shell.Current.GoToAsync("otpverification");
    }
}
