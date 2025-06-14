using GraphQL4Beginners.API.Model;
using Microsoft.EntityFrameworkCore;

namespace GraphQL4Beginners.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Book> Books => Set<Book>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "C# in Depth", Author = "Jon Skeet" },
            new Book { Id = 2, Title = "Clean Code", Author = "Robert Martin" }
        );
    }
}