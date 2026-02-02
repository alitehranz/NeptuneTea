using NeptuneTeaAPI.Models;

namespace NeptuneTeaAPI.Data;


/// <summary>
/// Seeds the database with the full Neptune Tea menu.
/// This runs once when the app starts to populate the MenuItems table.
/// All items match the frontend menu exactly.
/// </summary>

public static class DataSeeder
{
    /// <summary>
    /// Populates the database with menu items if it's empty.
    /// </summary>
    public static void SeedData (AppDbContext context)
    {
        // Only seed if the database is empty
        if (context.MenuItems.Any())
        {
            return; // Data already exists, skip seeding
        }

        var menuItems = new MenuItem[] // var allows the compiler to decide the datatype of these menu items
        {
            // === MILK TEA CLASSICS ===
            new MenuItem
            {
                Name = "Classic Milk Tea",
                Description = "Traditional black tea with creamy milk",
                Price = 5.50m, // m for decimal
                Category = Category.MilkTeaClassics 
            },
            
            new MenuItem
            {
                Name = "Brown Sugar Milk Tea",
                Description = "House-made brown sugar with fresh milk",
                Price = 6.00m,
                Category = Category.MilkTeaClassics
            },

            new MenuItem
            {
                Name = "Honeydew Milk Tea",
                Description = "Sweet melon flavor with smooth milk",
                Price = 5.75m,
                Category = Category.MilkTeaClassics
            },
                
            new MenuItem
            {
                Name = "Taro Milk Tea",
                Description = "Creamy taro root with a hint of vanilla",
                Price = 5.75m,
                Category = Category.MilkTeaClassics
            },
            
            new MenuItem
            {
                Name = "Matcha Milk Tea",
                Description = "Premium Japanese matcha with milk",
                Price = 6.25m,
                Category = Category.MilkTeaClassics
            },

            new MenuItem
            {
                Name = "Thai Milk Tea",
                Description = "Aromatic Thai tea with condensed milk",
                Price = 5.75m,
                Category = Category.MilkTeaClassics
            },

            new MenuItem
            {
                Name = "Oolong Milk Tea",
                Description = "Floral oolong with creamy finish",
                Price = 5.50m,
                Category = Category.MilkTeaClassics
            },

            new MenuItem
            {
                Name = "Jasmine Milk Tea",
                Description = "Fragrant jasmine tea with milk",
                Price = 5.50m,
                Category = Category.MilkTeaClassics
            },

            // === FRUIT TEA ===
            new MenuItem
            {
                Name = "Straberry Green Tea",
                Description = "Fresh strawberries with green tea",
                Price = 6.00m,
                Category = Category.FruitTea
            },

            new MenuItem
            {
                Name = "Peach Oolong",
                Description = "Sweet peach with floral oolong",
                Price = 6.00m,
                Category = Category.FruitTea
            },

            new MenuItem
            {
                Name = "Passion Fruit Tea",
                Description = "Tangy passion fruit with black tea",
                Price = 5.75m,
                Category = Category.FruitTea
            },

            new MenuItem
            {
                Name = "Lychee Rose Tea",
                Description = "Delicate lychee with rose petals",
                Price = 6.25m,
                Category = Category.FruitTea
            },

            new MenuItem
            {
                Name = "Mango Green Tea",
                Description = "Tropical mango with jasmine green",
                Price = 6.00m,
                Category = Category.FruitTea
            },

            new MenuItem
            {
                Name = "Grapefruit Tea",
                Description = "Citrus grapefruit with honey",
                Price = 5.75m,
                Category = Category.FruitTea
            },

            new MenuItem
            {
                Name = "Pomegranate Berry",
                Description = "Mixed berries with pomegranate",
                Price = 6.00m,
                Category = Category.FruitTea
            },

            new MenuItem
            {
                Name = "Yuzu Citrus Tea",
                Description = "Japanese yuzu with green tea",
                Price = 6.50m,
                Category = Category.FruitTea
            },

            // ===== CHEESE TEA =====
            new MenuItem { Name = "Cream Cheese Oolong", Description = "Smooth cheese foam on oolong tea", Price = 6.50m, Category = Category.CheeseTea },
            new MenuItem { Name = "Jasmine Cheese Tea", Description = "Floral jasmine with cheese cap", Price = 6.50m, Category = Category.CheeseTea },
            new MenuItem { Name = "Strawberry Cheese Tea", Description = "Fresh strawberry with cheese foam", Price = 7.00m, Category = Category.CheeseTea },
            new MenuItem { Name = "Matcha Cheese Tea", Description = "Premium matcha with cream cheese", Price = 7.00m, Category = Category.CheeseTea },
            new MenuItem { Name = "Peach Cheese Tea", Description = "Sweet peach with salted cheese", Price = 7.00m, Category = Category.CheeseTea },

             // ===== SPECIAL LATTES =====
            new MenuItem { Name = "Lavender Latte", Description = "Calming lavender with oat milk", Price = 6.50m, Category = Category.SpecialLattes },
            new MenuItem { Name = "Rose Latte", Description = "Delicate rose with steamed milk", Price = 6.50m, Category = Category.SpecialLattes },
            new MenuItem { Name = "Butterfly Pea Latte", Description = "Color-changing blue flower latte", Price = 6.75m, Category = Category.SpecialLattes },
            new MenuItem { Name = "Hojicha Latte", Description = "Roasted green tea with milk", Price = 6.25m, Category = Category.SpecialLattes },
            new MenuItem { Name = "Black Sesame Latte", Description = "Nutty sesame with creamy milk", Price = 6.50m, Category = Category.SpecialLattes },
            new MenuItem { Name = "Ube Latte", Description = "Purple yam with vanilla notes", Price = 6.75m, Category = Category.SpecialLattes },

            // ===== SEASONAL SPECIALS =====
            new MenuItem { Name = "Cherry Blossom Tea", Description = "Limited edition sakura infusion", Price = 7.25m, Category = Category.SeasonalSpecials },
            new MenuItem { Name = "Osmanthus Oolong", Description = "Fragrant osmanthus flower tea", Price = 6.75m, Category = Category.SeasonalSpecials },
            new MenuItem { Name = "White Peach Cream", Description = "Fresh white peach with milk foam", Price = 7.00m, Category = Category.SeasonalSpecials },
            new MenuItem { Name = "Elderflower Spritz", Description = "Sparkling elderflower with lemon", Price = 6.50m, Category = Category.SeasonalSpecials },
            new MenuItem { Name = "Honey Chrysanthemum", Description = "Soothing flower tea with honey", Price = 6.25m, Category = Category.SeasonalSpecials },
            new MenuItem { Name = "Golden Milk", Description = "Turmeric, ginger, and coconut", Price = 6.75m, Category = Category.SeasonalSpecials },
            new MenuItem { Name = "Plum Blossom Tea", Description = "Sweet plum with white tea", Price = 6.50m, Category = Category.SeasonalSpecials },
        };

        context.MenuItems.AddRange(menuItems);
        context.SaveChanges();
    }
}

           

           

  