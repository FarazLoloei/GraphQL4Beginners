using GraphQL4Beginners.API.Data;
using GraphQL4Beginners.API.Model;

namespace GraphQL4Beginners.API.Queries;

public class Query
{

    [UseFiltering]
    [UseSorting]
    [UsePaging]
    public IQueryable<Book> getBooks([Service] AppDbContext context)
        => context.Books.AsQueryable();

    public Book? getBook(int id, [Service] AppDbContext context)
        => context.Books.Find(id);
}