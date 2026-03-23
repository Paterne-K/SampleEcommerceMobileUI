# CamShop – Sample E-Commerce Mobile UI

A modern .NET MAUI mobile application UI for an e-commerce platform focused on selling clothes and shoes in Cameroon. Built with XAML, following MVVM architecture, using mock data only (no backend).

## Design Inspiration

UI/UX inspired by [this Dribbble design](https://dribbble.com/shots/24911825-Travel-Mobile-App), adapted to an African / Cameroonian e-commerce context with culturally relevant visuals, FCFA (XAF) currency, and realistic product names.

## Features

- **Clean, modern, premium UI** with card-based layouts, rounded corners, and shadows
- **MVVM architecture** with ViewModels, data binding, and commands
- **Shell navigation** with tab bar and route-based page navigation
- **Mock data service** with 15+ products across 8 categories
- **Reusable components** (ProductCard, CategoryCard, EmptyState, LoadingSkeleton)
- **Responsive mobile-first design**

## Screens & Flows

### Authentication Flow
- **Splash Screen** – Branded loading screen with app logo
- **Onboarding** – Carousel introducing app features
- **Login** – Email/password with social login options
- **Register** – Full registration form
- **OTP Verification** – 4-digit code verification

### Main App (Tab Navigation)
- **Home Page** – Promotions carousel, categories, popular items, new arrivals
- **Categories Page** – Grid of 8 product categories
- **Product List Page** – Filtered product grid with empty state
- **Product Details Page** – Full product info, size/color selection, quantity, add to cart
- **Cart Page** – Cart items with quantity controls, totals, checkout button

### Checkout Flow
- **Shipping Address** – Select from saved addresses
- **Delivery Options** – Standard, Express, Pickup point
- **Payment** – MTN Mobile Money, Orange Money, Card, Cash on Delivery
- **Order Summary** – Review all details before placing order
- **Order Success** – Confirmation with order ID

### User Area
- **Profile Page** – User info, account menu, logout
- **Orders History** – Past orders with status badges
- **Settings** – Notifications, dark mode, language, currency

## Project Structure

```
SampleEcommerceMobileUI/
├── SampleEcommerceMobileUI.sln
└── SampleEcommerceMobileUI/
    ├── SampleEcommerceMobileUI.csproj
    ├── App.xaml / App.xaml.cs
    ├── AppShell.xaml / AppShell.xaml.cs
    ├── MauiProgram.cs
    ├── GlobalUsings.cs
    ├── Models/
    │   ├── Product.cs
    │   ├── Category.cs
    │   ├── CartItem.cs
    │   ├── Order.cs
    │   ├── UserProfile.cs
    │   ├── ShippingAddress.cs
    │   ├── DeliveryOption.cs
    │   ├── PaymentMethod.cs
    │   ├── OnboardingItem.cs
    │   └── Promotion.cs
    ├── ViewModels/
    │   ├── BaseViewModel.cs
    │   ├── HomeViewModel.cs
    │   ├── CategoriesViewModel.cs
    │   ├── ProductListViewModel.cs
    │   ├── ProductDetailsViewModel.cs
    │   ├── CartViewModel.cs
    │   ├── LoginViewModel.cs
    │   ├── RegisterViewModel.cs
    │   ├── OtpVerificationViewModel.cs
    │   ├── ProfileViewModel.cs
    │   ├── OrdersHistoryViewModel.cs
    │   ├── SettingsViewModel.cs
    │   ├── ShippingAddressViewModel.cs
    │   ├── DeliveryOptionsViewModel.cs
    │   ├── PaymentViewModel.cs
    │   └── OrderSummaryViewModel.cs
    ├── Views/
    │   ├── Authentication/
    │   │   ├── SplashPage.xaml
    │   │   ├── OnboardingPage.xaml
    │   │   ├── LoginPage.xaml
    │   │   ├── RegisterPage.xaml
    │   │   └── OtpVerificationPage.xaml
    │   ├── Main/
    │   │   ├── HomePage.xaml
    │   │   ├── CategoriesPage.xaml
    │   │   ├── ProductListPage.xaml
    │   │   ├── ProductDetailsPage.xaml
    │   │   └── CartPage.xaml
    │   ├── Checkout/
    │   │   ├── ShippingAddressPage.xaml
    │   │   ├── DeliveryOptionsPage.xaml
    │   │   ├── PaymentPage.xaml
    │   │   ├── OrderSummaryPage.xaml
    │   │   └── OrderSuccessPage.xaml
    │   └── User/
    │       ├── ProfilePage.xaml
    │       ├── OrdersHistoryPage.xaml
    │       └── SettingsPage.xaml
    ├── Components/
    │   ├── ProductCard.xaml
    │   ├── CategoryCard.xaml
    │   ├── EmptyStateView.xaml
    │   └── LoadingSkeletonView.xaml
    ├── Services/
    │   └── MockDataService.cs
    ├── Converters/
    │   ├── InverseBoolConverter.cs
    │   └── BoolToColorConverter.cs
    ├── Resources/
    │   ├── Styles/
    │   │   ├── Colors.xaml
    │   │   └── Styles.xaml
    │   ├── Images/
    │   ├── Fonts/
    │   └── Raw/
    └── Platforms/
        ├── Android/
        ├── iOS/
        └── MacCatalyst/
```

## Tech Stack

- **.NET 9** with .NET MAUI
- **XAML** for UI layouts
- **C#** for code-behind and ViewModels
- **Shell Navigation** for page routing
- **Dependency Injection** via `MauiProgram.cs`

## Getting Started

### Prerequisites
- .NET 9 SDK
- .NET MAUI workload (`dotnet workload install maui`)
- Visual Studio 2022+ or VS Code with MAUI extension

### Run the App
```bash
dotnet restore
dotnet build
dotnet run --project SampleEcommerceMobileUI/SampleEcommerceMobileUI.csproj
```

## Color Palette

| Color | Hex | Usage |
|-------|-----|-------|
| Primary | `#1B1B1B` | Main text, buttons |
| Accent | `#FF6B35` | Prices, CTAs, highlights |
| Background | `#F8F8F8` | Page backgrounds |
| Surface | `#FFFFFF` | Cards, panels |
| Success | `#10B981` | Success states |
| Error | `#EF4444` | Error states |

## License

This project is for educational and demonstration purposes.