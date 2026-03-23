using Microsoft.Extensions.Logging;
using SampleEcommerceMobileUI.Views.Authentication;
using SampleEcommerceMobileUI.Views.Main;
using SampleEcommerceMobileUI.Views.Checkout;
using SampleEcommerceMobileUI.Views.User;

namespace SampleEcommerceMobileUI;

/// <summary>
/// Configures the MAUI application and registers services and pages.
/// </summary>
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Register services
        builder.Services.AddSingleton<MockDataService>();

        // Register ViewModels
        builder.Services.AddTransient<HomeViewModel>();
        builder.Services.AddTransient<CategoriesViewModel>();
        builder.Services.AddTransient<ProductListViewModel>();
        builder.Services.AddTransient<ProductDetailsViewModel>();
        builder.Services.AddSingleton<CartViewModel>();
        builder.Services.AddTransient<ProfileViewModel>();
        builder.Services.AddTransient<OrdersHistoryViewModel>();
        builder.Services.AddTransient<SettingsViewModel>();
        builder.Services.AddTransient<LoginViewModel>();
        builder.Services.AddTransient<RegisterViewModel>();
        builder.Services.AddTransient<OtpVerificationViewModel>();
        builder.Services.AddTransient<ShippingAddressViewModel>();
        builder.Services.AddTransient<DeliveryOptionsViewModel>();
        builder.Services.AddTransient<PaymentViewModel>();
        builder.Services.AddTransient<OrderSummaryViewModel>();

        // Register Pages
        builder.Services.AddTransient<SplashPage>();
        builder.Services.AddTransient<OnboardingPage>();
        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<RegisterPage>();
        builder.Services.AddTransient<OtpVerificationPage>();
        builder.Services.AddTransient<HomePage>();
        builder.Services.AddTransient<CategoriesPage>();
        builder.Services.AddTransient<ProductListPage>();
        builder.Services.AddTransient<ProductDetailsPage>();
        builder.Services.AddTransient<CartPage>();
        builder.Services.AddTransient<ShippingAddressPage>();
        builder.Services.AddTransient<DeliveryOptionsPage>();
        builder.Services.AddTransient<PaymentPage>();
        builder.Services.AddTransient<OrderSummaryPage>();
        builder.Services.AddTransient<OrderSuccessPage>();
        builder.Services.AddTransient<ProfilePage>();
        builder.Services.AddTransient<OrdersHistoryPage>();
        builder.Services.AddTransient<SettingsPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
