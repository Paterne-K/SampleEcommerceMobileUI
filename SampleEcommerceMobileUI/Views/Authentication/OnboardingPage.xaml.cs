using SampleEcommerceMobileUI.Services;

namespace SampleEcommerceMobileUI.Views.Authentication;

/// <summary>
/// Onboarding page with carousel introducing the app features.
/// </summary>
public partial class OnboardingPage : ContentPage
{
    public OnboardingPage()
    {
        InitializeComponent();
        var dataService = new MockDataService();
        OnboardingCarousel.ItemsSource = dataService.GetOnboardingItems();
    }

    private async void OnGetStartedClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("register");
    }

    private async void OnLoginClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("login");
    }
}
