namespace SampleEcommerceMobileUI.Views.User;

/// <summary>
/// Settings page for app preferences and configuration.
/// </summary>
public partial class SettingsPage : ContentPage
{
    public SettingsPage(SettingsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
