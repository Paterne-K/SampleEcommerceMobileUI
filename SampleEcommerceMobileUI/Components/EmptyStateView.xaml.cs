namespace SampleEcommerceMobileUI.Components;

/// <summary>
/// Reusable empty state view with icon, title, message and optional action button.
/// </summary>
public partial class EmptyStateView : ContentView
{
    public static readonly BindableProperty IconProperty =
        BindableProperty.Create(nameof(Icon), typeof(string), typeof(EmptyStateView), "📦",
            propertyChanged: (b, o, n) => ((EmptyStateView)b).IconLabel.Text = (string)n);

    public static readonly BindableProperty EmptyTitleProperty =
        BindableProperty.Create(nameof(EmptyTitle), typeof(string), typeof(EmptyStateView), "Nothing here",
            propertyChanged: (b, o, n) => ((EmptyStateView)b).TitleLabel.Text = (string)n);

    public static readonly BindableProperty MessageProperty =
        BindableProperty.Create(nameof(Message), typeof(string), typeof(EmptyStateView), string.Empty,
            propertyChanged: (b, o, n) => ((EmptyStateView)b).MessageLabel.Text = (string)n);

    public static readonly BindableProperty ButtonTextProperty =
        BindableProperty.Create(nameof(ButtonText), typeof(string), typeof(EmptyStateView), string.Empty,
            propertyChanged: (b, o, n) =>
            {
                var view = (EmptyStateView)b;
                view.ActionButton.Text = (string)n;
                view.ActionButton.IsVisible = !string.IsNullOrEmpty((string)n);
            });

    public string Icon { get => (string)GetValue(IconProperty); set => SetValue(IconProperty, value); }
    public string EmptyTitle { get => (string)GetValue(EmptyTitleProperty); set => SetValue(EmptyTitleProperty, value); }
    public string Message { get => (string)GetValue(MessageProperty); set => SetValue(MessageProperty, value); }
    public string ButtonText { get => (string)GetValue(ButtonTextProperty); set => SetValue(ButtonTextProperty, value); }

    public event EventHandler? ButtonClicked;

    public EmptyStateView()
    {
        InitializeComponent();
        ActionButton.Clicked += (s, e) => ButtonClicked?.Invoke(this, EventArgs.Empty);
    }
}
