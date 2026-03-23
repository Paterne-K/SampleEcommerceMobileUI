using SampleEcommerceMobileUI.Views.Authentication;
using SampleEcommerceMobileUI.Views.Main;
using SampleEcommerceMobileUI.Views.Checkout;
using SampleEcommerceMobileUI.Views.User;

namespace SampleEcommerceMobileUI;

/// <summary>
/// Application shell with route registrations for navigation.
/// </summary>
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Register routes for pages not in the tab bar
        Routing.RegisterRoute("onboarding", typeof(OnboardingPage));
        Routing.RegisterRoute("login", typeof(LoginPage));
        Routing.RegisterRoute("register", typeof(RegisterPage));
        Routing.RegisterRoute("otpverification", typeof(OtpVerificationPage));
        Routing.RegisterRoute("productlist", typeof(ProductListPage));
        Routing.RegisterRoute("productdetails", typeof(ProductDetailsPage));
        Routing.RegisterRoute("shippingaddress", typeof(ShippingAddressPage));
        Routing.RegisterRoute("deliveryoptions", typeof(DeliveryOptionsPage));
        Routing.RegisterRoute("payment", typeof(PaymentPage));
        Routing.RegisterRoute("ordersummary", typeof(OrderSummaryPage));
        Routing.RegisterRoute("ordersuccess", typeof(OrderSuccessPage));
        Routing.RegisterRoute("ordershistory", typeof(OrdersHistoryPage));
        Routing.RegisterRoute("settings", typeof(SettingsPage));
    }
}
