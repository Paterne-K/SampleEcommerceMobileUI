namespace SampleEcommerceMobileUI.Views.Authentication;

/// <summary>
/// Splash screen displayed on app launch. Navigates to onboarding after a delay.
/// </summary>
public partial class SplashPage : ContentPage
{
    public SplashPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        // Simulate loading time
        await Task.Delay(2500);
        await Shell.Current.GoToAsync("//main/home");
    }
}
