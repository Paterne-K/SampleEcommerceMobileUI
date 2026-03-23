namespace SampleEcommerceMobileUI.Services;

/// <summary>
/// Provides mock data for the entire application.
/// All data is hardcoded for UI demonstration purposes.
/// </summary>
public class MockDataService
{
    /// <summary>
    /// Returns a list of product categories.
    /// </summary>
    public List<Category> GetCategories()
    {
        return new List<Category>
        {
            new() { Id = 1, Name = "Men's Fashion", Icon = "👔", ProductCount = 124, Color = "#1B1B1B" },
            new() { Id = 2, Name = "Women's Fashion", Icon = "👗", ProductCount = 198, Color = "#FF6B35" },
            new() { Id = 3, Name = "Sneakers", Icon = "👟", ProductCount = 86, Color = "#3B82F6" },
            new() { Id = 4, Name = "Sandals", Icon = "🩴", ProductCount = 45, Color = "#10B981" },
            new() { Id = 5, Name = "Traditional Wear", Icon = "🪘", ProductCount = 67, Color = "#8B5CF6" },
            new() { Id = 6, Name = "Accessories", Icon = "⌚", ProductCount = 152, Color = "#F59E0B" },
            new() { Id = 7, Name = "Kids", Icon = "👶", ProductCount = 73, Color = "#EC4899" },
            new() { Id = 8, Name = "Sportswear", Icon = "🏃", ProductCount = 91, Color = "#06B6D4" }
        };
    }

    /// <summary>
    /// Returns a list of all available products.
    /// </summary>
    public List<Product> GetProducts()
    {
        return new List<Product>
        {
            // Men's Fashion
            new()
            {
                Id = 1, Name = "Ankara Print Shirt", Description = "Stylish Ankara print shirt made with premium African wax fabric. Perfect for casual and semi-formal occasions. Features modern slim-fit design with vibrant patterns inspired by Cameroonian culture.",
                Price = 15000, ImageUrl = "product_ankara_shirt.png", Category = "Men's Fashion",
                Rating = 4.8, ReviewCount = 124, IsPopular = true, IsNew = false,
                Sizes = new() { "S", "M", "L", "XL", "XXL" },
                Colors = new() { "Blue", "Red", "Green", "Yellow" }
            },
            new()
            {
                Id = 2, Name = "Classic Polo Shirt", Description = "Premium cotton polo shirt with a relaxed fit. Ideal for everyday wear in Douala's warm climate. Breathable fabric and classic design.",
                Price = 8500, ImageUrl = "product_polo.png", Category = "Men's Fashion",
                Rating = 4.5, ReviewCount = 89, IsPopular = true, IsNew = false,
                Sizes = new() { "S", "M", "L", "XL" },
                Colors = new() { "White", "Black", "Navy", "Grey" }
            },
            new()
            {
                Id = 3, Name = "Slim Fit Chinos", Description = "Modern slim-fit chinos made with stretch cotton. Perfect for a smart-casual look. Available in multiple earth tones.",
                Price = 12000, ImageUrl = "product_chinos.png", Category = "Men's Fashion",
                Rating = 4.6, ReviewCount = 56, IsPopular = false, IsNew = true,
                Sizes = new() { "30", "32", "34", "36", "38" },
                Colors = new() { "Khaki", "Navy", "Black", "Olive" }
            },

            // Women's Fashion
            new()
            {
                Id = 4, Name = "Kaba Ngondo Dress", Description = "Elegant Kaba Ngondo traditional dress with modern touches. Handcrafted with premium Ankara fabric. Perfect for ceremonies and special events.",
                Price = 25000, ImageUrl = "product_kaba.png", Category = "Women's Fashion",
                Rating = 4.9, ReviewCount = 201, IsPopular = true, IsNew = false,
                Sizes = new() { "S", "M", "L", "XL" },
                Colors = new() { "Gold", "Blue", "Green", "Red" }
            },
            new()
            {
                Id = 5, Name = "African Print Wrap Skirt", Description = "Beautiful African print wrap skirt. Versatile design that can be styled for casual or dressy occasions. Made with genuine wax print fabric.",
                Price = 10000, ImageUrl = "product_wrap_skirt.png", Category = "Women's Fashion",
                Rating = 4.7, ReviewCount = 143, IsPopular = true, IsNew = true,
                Sizes = new() { "S", "M", "L", "XL" },
                Colors = new() { "Multi", "Blue", "Orange" }
            },
            new()
            {
                Id = 6, Name = "Casual Summer Blouse", Description = "Light and airy summer blouse perfect for Cameroon's tropical climate. Features flowy design with African-inspired patterns.",
                Price = 7500, ImageUrl = "product_blouse.png", Category = "Women's Fashion",
                Rating = 4.4, ReviewCount = 78, IsPopular = false, IsNew = true,
                Sizes = new() { "XS", "S", "M", "L", "XL" },
                Colors = new() { "White", "Pink", "Yellow" }
            },

            // Sneakers
            new()
            {
                Id = 7, Name = "Urban Street Sneakers", Description = "Trendy urban sneakers with comfortable cushioning. Perfect for daily wear. Lightweight and breathable design.",
                Price = 22000, ImageUrl = "product_sneakers_urban.png", Category = "Sneakers",
                Rating = 4.7, ReviewCount = 312, IsPopular = true, IsNew = false,
                Sizes = new() { "39", "40", "41", "42", "43", "44", "45" },
                Colors = new() { "White", "Black", "Red" }
            },
            new()
            {
                Id = 8, Name = "Running Shoes Pro", Description = "High-performance running shoes with advanced cushioning technology. Ideal for jogging along Douala's Bonanjo promenade.",
                Price = 35000, ImageUrl = "product_running_shoes.png", Category = "Sneakers",
                Rating = 4.8, ReviewCount = 189, IsPopular = true, IsNew = true,
                Sizes = new() { "39", "40", "41", "42", "43", "44" },
                Colors = new() { "Blue", "Black", "Green" }
            },
            new()
            {
                Id = 9, Name = "Canvas Low-Top", Description = "Classic canvas low-top sneakers. Simple, clean design that goes with everything. Affordable style for students and professionals.",
                Price = 9000, ImageUrl = "product_canvas.png", Category = "Sneakers",
                Rating = 4.3, ReviewCount = 267, IsPopular = false, IsNew = false,
                Sizes = new() { "38", "39", "40", "41", "42", "43" },
                Colors = new() { "White", "Black", "Navy", "Red" }
            },

            // Sandals
            new()
            {
                Id = 10, Name = "Leather Gladiator Sandals", Description = "Handcrafted leather gladiator sandals. Durable and stylish with genuine leather straps. Perfect for Cameroon's warm weather.",
                Price = 18000, ImageUrl = "product_gladiator.png", Category = "Sandals",
                Rating = 4.6, ReviewCount = 98, IsPopular = true, IsNew = false,
                Sizes = new() { "37", "38", "39", "40", "41", "42" },
                Colors = new() { "Brown", "Black", "Tan" }
            },
            new()
            {
                Id = 11, Name = "Comfort Slide Sandals", Description = "Ultra-comfortable slide sandals with cushioned footbed. Great for casual everyday wear and relaxation.",
                Price = 6500, ImageUrl = "product_slides.png", Category = "Sandals",
                Rating = 4.4, ReviewCount = 156, IsPopular = false, IsNew = true,
                Sizes = new() { "38", "39", "40", "41", "42", "43" },
                Colors = new() { "Black", "Brown", "White" }
            },

            // Traditional Wear
            new()
            {
                Id = 12, Name = "Grand Boubou Set", Description = "Magnificent Grand Boubou set with intricate embroidery. Premium fabric with detailed hand-stitched patterns. For special celebrations and ceremonies.",
                Price = 45000, ImageUrl = "product_boubou.png", Category = "Traditional Wear",
                Rating = 4.9, ReviewCount = 87, IsPopular = true, IsNew = false,
                Sizes = new() { "M", "L", "XL", "XXL" },
                Colors = new() { "White", "Blue", "Gold" }
            },
            new()
            {
                Id = 13, Name = "Toghu Royal Vest", Description = "Authentic Toghu vest from the Bamenda highlands. Traditional Cameroonian embroidered fabric. A cultural treasure for your wardrobe.",
                Price = 30000, ImageUrl = "product_toghu.png", Category = "Traditional Wear",
                Rating = 4.8, ReviewCount = 65, IsPopular = true, IsNew = true,
                Sizes = new() { "S", "M", "L", "XL" },
                Colors = new() { "Black/Red", "Black/Yellow", "Black/Green" }
            },

            // Accessories
            new()
            {
                Id = 14, Name = "Beaded Necklace Set", Description = "Handmade beaded necklace set with traditional African patterns. Each piece is unique and crafted by local Cameroonian artisans.",
                Price = 5000, ImageUrl = "product_necklace.png", Category = "Accessories",
                Rating = 4.5, ReviewCount = 234, IsPopular = true, IsNew = false,
                Sizes = new() { "One Size" },
                Colors = new() { "Multi", "Gold", "Red" }
            },
            new()
            {
                Id = 15, Name = "Leather Crossbody Bag", Description = "Genuine leather crossbody bag with African-inspired design elements. Spacious compartments and adjustable strap.",
                Price = 20000, ImageUrl = "product_crossbody.png", Category = "Accessories",
                Rating = 4.7, ReviewCount = 178, IsPopular = true, IsNew = true,
                Sizes = new() { "One Size" },
                Colors = new() { "Brown", "Black", "Tan" }
            }
        };
    }

    /// <summary>
    /// Returns featured/popular products for the home page.
    /// </summary>
    public List<Product> GetFeaturedProducts()
    {
        return GetProducts().Where(p => p.IsPopular).ToList();
    }

    /// <summary>
    /// Returns new arrival products.
    /// </summary>
    public List<Product> GetNewArrivals()
    {
        return GetProducts().Where(p => p.IsNew).ToList();
    }

    /// <summary>
    /// Returns products filtered by category name.
    /// </summary>
    public List<Product> GetProductsByCategory(string category)
    {
        return GetProducts().Where(p => p.Category == category).ToList();
    }

    /// <summary>
    /// Returns a single product by its ID.
    /// </summary>
    public Product? GetProductById(int id)
    {
        return GetProducts().FirstOrDefault(p => p.Id == id);
    }

    /// <summary>
    /// Returns promotional banners for the home page.
    /// </summary>
    public List<Promotion> GetPromotions()
    {
        return new List<Promotion>
        {
            new() { Id = 1, Title = "New Collection", Subtitle = "Up to 40% off on African prints", ImageUrl = "promo_banner1.png", BackgroundColor = "#FF6B35", DiscountPercent = 40 },
            new() { Id = 2, Title = "Weekend Sale", Subtitle = "Free delivery on orders above 20,000 FCFA", ImageUrl = "promo_banner2.png", BackgroundColor = "#1B1B1B", DiscountPercent = 0 },
            new() { Id = 3, Title = "Traditional Wear", Subtitle = "Celebrate culture with 25% off", ImageUrl = "promo_banner3.png", BackgroundColor = "#8B5CF6", DiscountPercent = 25 }
        };
    }

    /// <summary>
    /// Returns onboarding carousel items.
    /// </summary>
    public List<OnboardingItem> GetOnboardingItems()
    {
        return new List<OnboardingItem>
        {
            new() { Title = "Discover African Fashion", Description = "Explore a curated collection of clothes, shoes, and accessories inspired by Cameroonian culture.", ImageUrl = "onboarding1.png" },
            new() { Title = "Shop with Ease", Description = "Browse categories, compare prices, and find the perfect outfit — all from your phone.", ImageUrl = "onboarding2.png" },
            new() { Title = "Fast & Secure Delivery", Description = "Get your orders delivered across Cameroon with Mobile Money and card payment options.", ImageUrl = "onboarding3.png" }
        };
    }

    /// <summary>
    /// Returns available delivery options.
    /// </summary>
    public List<DeliveryOption> GetDeliveryOptions()
    {
        return new List<DeliveryOption>
        {
            new() { Id = 1, Name = "Standard Delivery", Description = "Delivered to your door", Price = 2000, EstimatedDays = "3-5 business days", Icon = "🚚" },
            new() { Id = 2, Name = "Express Delivery", Description = "Fast delivery within the city", Price = 5000, EstimatedDays = "1-2 business days", Icon = "⚡" },
            new() { Id = 3, Name = "Pickup Point", Description = "Collect from nearest pickup point", Price = 0, EstimatedDays = "2-4 business days", Icon = "📦" }
        };
    }

    /// <summary>
    /// Returns available payment methods.
    /// </summary>
    public List<PaymentMethod> GetPaymentMethods()
    {
        return new List<PaymentMethod>
        {
            new() { Id = 1, Name = "MTN Mobile Money", Description = "Pay with MTN MoMo", Icon = "📱", Type = "MobileMoney" },
            new() { Id = 2, Name = "Orange Money", Description = "Pay with Orange Money", Icon = "📱", Type = "MobileMoney" },
            new() { Id = 3, Name = "Visa / Mastercard", Description = "Pay with debit or credit card", Icon = "💳", Type = "Card" },
            new() { Id = 4, Name = "Cash on Delivery", Description = "Pay when you receive your order", Icon = "💵", Type = "Cash" }
        };
    }

    /// <summary>
    /// Returns mock saved shipping addresses.
    /// </summary>
    public List<ShippingAddress> GetSavedAddresses()
    {
        return new List<ShippingAddress>
        {
            new() { Id = 1, FullName = "Paterne K.", Phone = "+237 6XX XXX XXX", Street = "Rue de la Joie, Akwa", City = "Douala", Region = "Littoral", IsDefault = true },
            new() { Id = 2, FullName = "Paterne K.", Phone = "+237 6XX XXX XXX", Street = "Avenue Kennedy, Bastos", City = "Yaoundé", Region = "Centre", IsDefault = false }
        };
    }

    /// <summary>
    /// Returns mock order history.
    /// </summary>
    public List<Order> GetOrderHistory()
    {
        var products = GetProducts();
        return new List<Order>
        {
            new()
            {
                OrderId = "CAM-2024-001", OrderDate = new DateTime(2024, 12, 15),
                Items = new() { new() { Product = products[0], Quantity = 1, SelectedSize = "L" }, new() { Product = products[6], Quantity = 1, SelectedSize = "42" } },
                TotalAmount = 37000, Status = "Delivered", ShippingAddress = "Rue de la Joie, Akwa, Douala", PaymentMethod = "MTN Mobile Money"
            },
            new()
            {
                OrderId = "CAM-2024-002", OrderDate = new DateTime(2025, 1, 8),
                Items = new() { new() { Product = products[3], Quantity = 1, SelectedSize = "M" } },
                TotalAmount = 25000, Status = "Shipped", ShippingAddress = "Avenue Kennedy, Bastos, Yaoundé", PaymentMethod = "Orange Money"
            },
            new()
            {
                OrderId = "CAM-2024-003", OrderDate = new DateTime(2025, 2, 20),
                Items = new() { new() { Product = products[13], Quantity = 2 }, new() { Product = products[11], Quantity = 1, SelectedSize = "XL" } },
                TotalAmount = 55000, Status = "Processing", ShippingAddress = "Rue de la Joie, Akwa, Douala", PaymentMethod = "Visa / Mastercard"
            }
        };
    }

    /// <summary>
    /// Returns the current user's profile.
    /// </summary>
    public UserProfile GetUserProfile()
    {
        return new UserProfile();
    }
}
