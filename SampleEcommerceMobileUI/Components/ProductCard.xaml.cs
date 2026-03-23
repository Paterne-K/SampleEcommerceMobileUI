namespace SampleEcommerceMobileUI.Components;

/// <summary>
/// Reusable product card component for displaying product information.
/// </summary>
public partial class ProductCard : ContentView
{
    public static readonly BindableProperty ProductNameProperty =
        BindableProperty.Create(nameof(ProductName), typeof(string), typeof(ProductCard), string.Empty,
            propertyChanged: (b, o, n) => ((ProductCard)b).ProductNameLabel.Text = (string)n);

    public static readonly BindableProperty CategoryProperty =
        BindableProperty.Create(nameof(Category), typeof(string), typeof(ProductCard), string.Empty,
            propertyChanged: (b, o, n) => ((ProductCard)b).CategoryLabel.Text = (string)n);

    public static readonly BindableProperty PriceProperty =
        BindableProperty.Create(nameof(Price), typeof(string), typeof(ProductCard), string.Empty,
            propertyChanged: (b, o, n) => ((ProductCard)b).PriceLabel.Text = (string)n);

    public static readonly BindableProperty RatingProperty =
        BindableProperty.Create(nameof(Rating), typeof(string), typeof(ProductCard), string.Empty,
            propertyChanged: (b, o, n) => ((ProductCard)b).RatingLabel.Text = (string)n);

    public string ProductName { get => (string)GetValue(ProductNameProperty); set => SetValue(ProductNameProperty, value); }
    public string Category { get => (string)GetValue(CategoryProperty); set => SetValue(CategoryProperty, value); }
    public string Price { get => (string)GetValue(PriceProperty); set => SetValue(PriceProperty, value); }
    public string Rating { get => (string)GetValue(RatingProperty); set => SetValue(RatingProperty, value); }

    public ProductCard()
    {
        InitializeComponent();
    }
}
