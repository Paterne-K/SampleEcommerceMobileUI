using System.Windows.Input;

namespace SampleEcommerceMobileUI.ViewModels;

/// <summary>
/// ViewModel for the Login page.
/// </summary>
public class LoginViewModel : BaseViewModel
{
    private string _email = string.Empty;
    private string _password = string.Empty;

    public string Email
    {
        get => _email;
        set => SetProperty(ref _email, value);
    }

    public string Password
    {
        get => _password;
        set => SetProperty(ref _password, value);
    }

    public ICommand LoginCommand { get; }
    public ICommand NavigateToRegisterCommand { get; }
    public ICommand ForgotPasswordCommand { get; }
    public ICommand SocialLoginCommand { get; }

    public LoginViewModel()
    {
        Title = "Login";
        LoginCommand = new Command(async () => await Login());
        NavigateToRegisterCommand = new Command(async () => await Shell.Current.GoToAsync("register"));
        ForgotPasswordCommand = new Command(async () => await Shell.Current.DisplayAlert("Forgot Password", "A reset link would be sent to your email.", "OK"));
        SocialLoginCommand = new Command<string>(async (provider) => await SocialLogin(provider));
    }

    private async Task Login()
    {
        if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
        {
            await Shell.Current.DisplayAlert("Error", "Please enter your email and password.", "OK");
            return;
        }
        // Mock login - navigate to main app
        await Shell.Current.GoToAsync("//home");
    }

    private async Task SocialLogin(string provider)
    {
        await Shell.Current.DisplayAlert("Social Login", $"Login with {provider} would be initiated.", "OK");
        await Shell.Current.GoToAsync("//home");
    }
}
