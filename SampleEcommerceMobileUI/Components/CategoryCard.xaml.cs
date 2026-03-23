namespace SampleEcommerceMobileUI.Components;

/// <summary>
/// Reusable category card component for displaying product categories.
/// </summary>
public partial class CategoryCard : ContentView
{
    public static readonly BindableProperty IconProperty =
        BindableProperty.Create(nameof(Icon), typeof(string), typeof(CategoryCard), string.Empty,
            propertyChanged: (b, o, n) => ((CategoryCard)b).IconLabel.Text = (string)n);

    public static readonly BindableProperty CategoryNameProperty =
        BindableProperty.Create(nameof(CategoryName), typeof(string), typeof(CategoryCard), string.Empty,
            propertyChanged: (b, o, n) => ((CategoryCard)b).NameLabel.Text = (string)n);

    public static readonly BindableProperty ItemCountProperty =
        BindableProperty.Create(nameof(ItemCount), typeof(string), typeof(CategoryCard), string.Empty,
            propertyChanged: (b, o, n) => ((CategoryCard)b).CountLabel.Text = (string)n);

    public string Icon { get => (string)GetValue(IconProperty); set => SetValue(IconProperty, value); }
    public string CategoryName { get => (string)GetValue(CategoryNameProperty); set => SetValue(CategoryNameProperty, value); }
    public string ItemCount { get => (string)GetValue(ItemCountProperty); set => SetValue(ItemCountProperty, value); }

    public CategoryCard()
    {
        InitializeComponent();
    }
}
