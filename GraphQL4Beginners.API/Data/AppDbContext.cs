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
            new Book { Id = 2, Title = "Clean Code", Author = "Robert C. Martin" },
            new Book { Id = 3, Title = "Design Patterns", Author = "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides" },
            new Book { Id = 4, Title = "CLR via C#", Author = "Jeffrey Richter" },
            new Book { Id = 5, Title = "Refactoring", Author = "Martin Fowler" },
            new Book { Id = 6, Title = "C# 10 and .NET 6", Author = "Mark J. Price" },
            new Book { Id = 7, Title = "GraphQL in Action", Author = "Samer Buna" },
            new Book { Id = 8, Title = "Entity Framework Core in Action", Author = "Jon P Smith" },
            new Book { Id = 9, Title = "ASP.NET Core in Action", Author = "Andrew Lock" },
            new Book { Id = 10, Title = "Algorithms", Author = "Robert Sedgewick" },
            new Book { Id = 11, Title = "The Pragmatic Programmer", Author = "Andrew Hunt, David Thomas" },
            new Book { Id = 12, Title = "Code Complete", Author = "Steve McConnell" },
            new Book { Id = 13, Title = "Head First Design Patterns", Author = "Eric Freeman, Elisabeth Robson" },
            new Book { Id = 14, Title = "Domain-Driven Design", Author = "Eric Evans" },
            new Book { Id = 15, Title = "Working Effectively with Legacy Code", Author = "Michael Feathers" },
            new Book { Id = 16, Title = "Test-Driven Development", Author = "Kent Beck" },
            new Book { Id = 17, Title = "Patterns of Enterprise Application Architecture", Author = "Martin Fowler" },
            new Book { Id = 18, Title = "Continuous Delivery", Author = "Jez Humble, David Farley" },
            new Book { Id = 19, Title = "Release It!", Author = "Michael T. Nygard" },
            new Book { Id = 20, Title = "The Clean Coder", Author = "Robert C. Martin" },
            new Book { Id = 21, Title = "You Don't Know JS", Author = "Kyle Simpson" }
        );
    }
}