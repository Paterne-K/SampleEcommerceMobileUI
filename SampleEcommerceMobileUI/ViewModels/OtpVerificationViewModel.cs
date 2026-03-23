using System.Windows.Input;

namespace SampleEcommerceMobileUI.ViewModels;

/// <summary>
/// ViewModel for the OTP Verification page.
/// </summary>
public class OtpVerificationViewModel : BaseViewModel
{
    private string _otp1 = string.Empty;
    private string _otp2 = string.Empty;
    private string _otp3 = string.Empty;
    private string _otp4 = string.Empty;

    public string Otp1 { get => _otp1; set => SetProperty(ref _otp1, value); }
    public string Otp2 { get => _otp2; set => SetProperty(ref _otp2, value); }
    public string Otp3 { get => _otp3; set => SetProperty(ref _otp3, value); }
    public string Otp4 { get => _otp4; set => SetProperty(ref _otp4, value); }

    public ICommand VerifyCommand { get; }
    public ICommand ResendCodeCommand { get; }

    public OtpVerificationViewModel()
    {
        Title = "Verification";
        VerifyCommand = new Command(async () => await Verify());
        ResendCodeCommand = new Command(async () => await ResendCode());
    }

    private async Task Verify()
    {
        var otp = $"{Otp1}{Otp2}{Otp3}{Otp4}";
        if (otp.Length < 4)
        {
            await Shell.Current.DisplayAlert("Error", "Please enter the complete verification code.", "OK");
            return;
        }
        // Mock verification success
        await Shell.Current.GoToAsync("//home");
    }

    private async Task ResendCode()
    {
        await Shell.Current.DisplayAlert("Code Resent", "A new verification code has been sent to your phone.", "OK");
    }
}
