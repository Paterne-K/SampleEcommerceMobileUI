namespace SampleEcommerceMobileUI.Views.User;

/// <summary>
/// Profile page showing user info and navigation to account settings.
/// </summary>
public partial class ProfilePage : ContentPage
{
    public ProfilePage(ProfileViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
