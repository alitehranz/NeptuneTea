using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;
using NeptuneTeaAPI.Data;
using NeptuneTeaAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// ===== CONFIGURE SERVICES =====

// 1. Add database context with SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=neptunetea.db"));

// 2. Add Swagger/OpenAPI services (Missing this was causing your 404)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 3. Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("RestrictedOrigins", policy =>
    {
        policy.WithOrigins("https://neptunetea-shop.netlify.app") // No trailing slash
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// ===== SEED DATABASE ON STARTUP =====

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    context.Database.EnsureCreated();
    DataSeeder.SeedData(context);
}

// ===== CONFIGURE MIDDLEWARE =====

// Enable Swagger UI as the Home Page
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Neptune Tea API v1");
    options.RoutePrefix = string.Empty; // Makes Swagger load at http://localhost:5000/
});

// Use the exact policy name we defined above
app.UseCors("RestrictedOrigins");

// ===== DEFINE API ENDPOINTS =====

app.MapGet("/api/menu", async (AppDbContext db) =>
{
    var items = await db.MenuItems.ToListAsync();
    return Results.Ok(items);
})
.WithName("GetAllMenuItems")
.WithOpenApi();

app.MapGet("/api/menu/{category}", async (string category, AppDbContext db) =>
{
    if (!Enum.TryParse<Category>(category, true, out var categoryEnum))
    {
        return Results.BadRequest(new { error = $"Invalid category: {category}" });
    }

    var items = await db.MenuItems
        .Where(m => m.Category == categoryEnum)
        .ToListAsync();

    return Results.Ok(items);
})
.WithName("GetMenuItemsByCategory")
.WithOpenApi();

app.MapPost("/api/orders", async (Order order, AppDbContext db) =>
{
    if (string.IsNullOrWhiteSpace(order.ItemName))
    {
        return Results.BadRequest(new { error = "ItemName is required" });
    }

    if (order.Quantity <= 0)
    {
        return Results.BadRequest(new { error = "Quantity must be greater than 0" });
    }

    db.Orders.Add(order);
    await db.SaveChangesAsync();

    return Results.Created($"/api/orders/{order.Id}", order);
})
.WithName("CreateOrder")
.WithOpenApi();

// ===== START THE API =====

Console.WriteLine("🚀 Neptune Tea API is running!");
Console.WriteLine("📍 Swagger UI available at: http://localhost:5000/");

app.Run();