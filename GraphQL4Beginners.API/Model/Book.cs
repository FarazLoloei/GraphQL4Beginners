namespace GraphQL4Beginners.API.Model;

/// <summary>Represents a book in the system</summary>
public class Book
{
    /// <summary>The unique book identifier</summary>
    public int Id { get; set; }

    /// <summary>The book's title</summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>The book's author</summary>
    public string Author { get; set; } = string.Empty;
}