# Library System

## Overview
The **Library System** is a simple console-based application developed in C# to manage books in a library. It allows users to add, remove, display, and borrow books using an array-based approach.

## Features
- **Add Books**: Add books to the library collection.
- **Remove Books**: Remove books from the library.
- **Display Books**: View all books available in the library.
- **Borrow Books**: Borrow books from the library (limited capacity).

## Prerequisites
- **.NET Framework** or **.NET Core** installed on your system.
- Basic knowledge of C# and object-oriented programming.

## Installation
1. Clone or download the repository.
2. Open the project in **Visual Studio** or any C#-compatible IDE.
3. Build and run the application.

## Usage
1. Create a `Library` object.
2. Use the `Add(Book book)` method to add books.
3. Use `RemoveBook(Book book)` to remove books from the library.
4. Call `DisplyBook()` to list available books.
5. Use `BorrowBook(Book book)` to borrow books.

## Code Example
```csharp
Library library = new Library();
Book book1 = new Book("C# Programming", "John Doe");
library.Add(book1);
library.DisplyBook();
library.BorrowBook(book1);
```

## Known Issues
- The `RemoveBook` method does not properly shift elements after removing a book.
- The `BorrowBook` method mistakenly adds books to the `Books` array instead of `BorrowedBooks`.
- The `DisplyBook` method does not handle `null` values properly.

## Future Improvements
- Use a `List<Book>` instead of fixed-size arrays.
- Implement proper validation and error handling.
- Improve the `BorrowBook` logic to track borrowed books correctly.
- Implement a search functionality to find books easily.

## License
This project is open-source and free to use under the **MIT License**.

## Contact
For any issues or suggestions, feel free to reach out!

