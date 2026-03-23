namespace SampleEcommerceMobileUI;

/// <summary>
/// Main application class. Sets the initial page to AppShell.
/// </summary>
public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}
