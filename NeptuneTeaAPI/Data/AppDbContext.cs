using Microsoft.EntityFrameworkCore;
using NeptuneTeaAPI.Models;

namespace NeptuneTeaAPI.Data;

/// <summary>
/// Database context for Neptune Tea API.
/// This class manages the connection to the SQLite database and defines what tables exist.
/// Entity Framework uses this to create and query the database.
/// </summary>

public class AppDbContext : DbContext
{
    /// <summary>
    /// Constructor that accepts configuration options (like database connection string)
    /// </summary>
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    /// <summary>
    /// The MenuItems table - stores all drinks available at Neptune Tea
    /// </summary>
    public DbSet<MenuItem> MenuItems { get; set; }

    /// <summary>
    /// The orders table - stores customer orders
    /// </summary>
    public DbSet<Order> Orders {get; set;}

    /// <summary>
    /// Called when the model is being created.
    /// This is where we can configure table relationships, constraints, etc.
    /// For this project, using the defaults.
    /// </summary>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // STORE category enum as string in database (more redable than integer)
        modelBuilder.Entity<MenuItem>()
            .Property(m => m.Category) 
            .HasConversion<string>(); // allows to format different data type from the type used in c# app code.
            
    }
}