# **GraphQL Book API with HotChocolate v15**

This project implements a GraphQL API for book management using **HotChocolate v15** and an in-memory database. It provides full **CRUD** operations with **pagination**, **filtering**, and **sorting** capabilities.

## **Features**

* **CRUD Operations**: Create, read, update, and delete books.  
* **Pagination**: Supports both offset and cursor-based pagination.  
* **Filtering**: Enables complex filtering by book properties.  
* **Sorting**: Provides multi-field sorting options.  
* **In-Memory Database**: Easy setup with Entity Framework Core.  
* **HotChocolate v15**: Utilizes the latest GraphQL server implementation for .NET.

## **Prerequisites**

To run this project, you'll need:

* **.NET 6.0 SDK**  
* An IDE (Visual Studio, VS Code, or Rider)

## **Getting Started**

Follow these steps to get the project up and running:

1. **Clone the repository**:  
   git clone https://github.com/your-username/GraphQL4Beginners.git  
   cd GraphQL4Beginners

2. **Restore dependencies**:  
   dotnet restore

3. **Run the application**:  
   dotnet run

4. Access GraphQL IDE:  
   Open your browser and navigate to https://localhost:5000/graphql (the port may vary depending on your configuration).

## **GraphQL Operations**

This section provides examples of common GraphQL queries and mutations.

### **1\. Get a Single Book**

Retrieve a book by its ID.
```
query {  
  getBook(id: 1\) {  
    id  
    title  
    author  
  }  
}
```

### **2\. Get All Books with Cursor-based Pagination**

Retrieve books using cursor-based pagination.
```
query {  
  getBooks(first: 10\) {  
    edges {  
      node {  
        id  
        title  
        author  
      }  
      cursor  
    }  
    pageInfo {  
      hasNextPage  
      endCursor  
    }  
  }  
}
```

### **3\. Get Next Page of Books**

Retrieve the next page of books using a cursor.
```
query {  
  getBooks(first: 10, after: "OQ==") {  
    edges {  
      node {  
        id  
        title  
        author  
      }  
    }  
    pageInfo {  
      hasNextPage  
      endCursor  
    }  
  }  
}
```

### **4\. Add a New Book**

Create a new book.

```
mutation {  
  addBook(title: "The Hobbit", author: "J.R.R. Tolkien") {  
    id  
    title  
    author  
  }  
}
```

### **5\. Update a Book**

Modify an existing book.

```
mutation {  
  updateBook(  
    id: 1  
    title: "The Hobbit \- Revised"  
    author: "J.R.R. Tolkien"  
  ) {  
    id  
    title  
  }  
}
```

### **6\. Delete a Book**

Remove a book from the database.

```
mutation {  
  deleteBook(id: 1\)  
}
```

### **7\. Filter Books with Pagination**

Retrieve filtered books with pagination.

```
query {  
  getBooks(  
    first: 5  
    where: { author: { eq: "Martin Fowler" } }  
  ) {  
    edges {  
      node {  
        id  
        title  
        author  
      }  
    }  
    pageInfo {  
      hasNextPage  
      endCursor  
    }  
  }  
}
```

### **8\. Get Books with Sorting**

Retrieve books sorted by title.

```
query {  
  getBooks(order: { title: DESC }) {  
    edges {  
      node {  
        id  
        title  
      }  
    }  
  }  
}
```
### **9\. Complex Filtering**

Combine multiple filter conditions.

```GraphQl
query {  
  getBooks(  
    where: {  
      OR: \[  
        { title: { contains: "C\#" } }  
        { author: { contains: "Martin" } }  
      \]  
    }  
  ) {  
    edges {  
      node {  
        id  
        title  
        author  
      }  
    }  
  }  
}
```
## **Database Initialization**

The in-memory database is pre-seeded with 21 books covering various programming topics:

* **C\# in Depth** \- Jon Skeet  
* **Clean Code** \- Robert C. Martin  
* **Design Patterns** \- Erich Gamma, et al.  
* **CLR via C\#** \- Jeffrey Richter  
* **Refactoring** \- Martin Fowler  
* **C\# 10 and .NET 6** \- Mark J. Price  
* **GraphQL in Action** \- Samer Buna  
* **Entity Framework Core in Action** \- Jon P Smith  
* **ASP.NET Core in Action** \- Andrew Lock  
* **Algorithms** \- Robert Sedgewick  
* **The Pragmatic Programmer** \- Andrew Hunt, David Thomas  
* **Code Complete** \- Steve McConnell  
* **Head First Design Patterns** \- Eric Freeman, Elisabeth Robson  
* **Domain-Driven Design** \- Eric Evans  
* **Working Effectively with Legacy Code** \- Michael Feathers  
* **Test-Driven Development** \- Kent Beck  
* **Patterns of Enterprise Application Architecture** \- Martin Fowler  
* **Continuous Delivery** \- Jez Humble, David Farley  
* **Release It\!** \- Michael T. Nygard  
* **The Clean Coder** \- Robert C. Martin  
* **You Don't Know JS** \- Kyle Simpson

## **Project Structure**

* Program.cs: Application startup and configuration.  
* Models/Book.cs: Defines the Book model.  
* Data/AppDbContext.cs: The Entity Framework database context.  
* GraphQL/Queries.cs: Contains GraphQL query definitions.  
* GraphQL/Mutations.cs: Contains GraphQL mutation definitions.

## **Technologies Used**

* **HotChocolate v15**: GraphQL server implementation.  
* **Entity Framework Core**: ORM for database access.  
* **ASP.NET Core**: Web framework.  
* **Banana Cake Pop**: GraphQL IDE.

## **Contributing**

Contributions are welcome\! Please fork the repository and create a pull request with your changes.

## **License**

This project is licensed under the MIT License \- see the LICENSE file for details.