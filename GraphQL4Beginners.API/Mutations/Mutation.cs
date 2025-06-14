using GraphQL4Beginners.API.Data;
using GraphQL4Beginners.API.Model;

namespace GraphQL4Beginners.API.Mutations;

public class Mutation
{
    public async Task<Book> addBook(
        string title,
        string author,
        [Service] AppDbContext context)
    {
        var book = new Book { Title = title, Author = author };
        context.Books.Add(book);
        await context.SaveChangesAsync();
        return book;
    }

    public async Task<Book?> updateBook(
        int id,
        string? title,
        string? author,
        [Service] AppDbContext context)
    {
        var book = await context.Books.FindAsync(id);
        if (book == null) return null;

        book.Title = title ?? book.Title;
        book.Author = author ?? book.Author;
        await context.SaveChangesAsync();
        return book;
    }

    public async Task<bool> deleteBook(int id, [Service] AppDbContext context)
    {
        var book = await context.Books.FindAsync(id);
        if (book == null) return false;

        context.Books.Remove(book);
        await context.SaveChangesAsync();
        return true;
    }
}