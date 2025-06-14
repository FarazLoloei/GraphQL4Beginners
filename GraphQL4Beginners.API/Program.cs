using GraphQL4Beginners.API.Data;
using GraphQL4Beginners.API.Mutations;
using GraphQL4Beginners.API.Queries;
using Microsoft.EntityFrameworkCore;

namespace GraphQL4Beginners.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configure in-memory database
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseInMemoryDatabase("BookDB"));

            // Add GraphQL server
            builder.Services
                .AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>()
                //.addpa
                //.AddPaging() // For paging support
                .AddProjections() // Enable field selection
                .AddFiltering()
                .AddSorting();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                context.Database.EnsureCreated();
            }

            app.MapGraphQL(); // Endpoint: /graphql

            app.Run();
        }
    }
}