using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Library
    {
        private Book[] Books = new Book[100];
        private int CurrentBookCount = 0;
        private Book[] BorrowedBooks = new Book[50];
        private int CurrentBorrowedBookCount = 0;

        public void Add(Book book)
        {
            if (CurrentBookCount < Books.Length)
            {
                Books[CurrentBookCount] = book;
                CurrentBookCount++;
                Console.WriteLine("Book Is Added");
            }
            else
            {
                Console.WriteLine("Library is full");
            }
        }
        public void RemoveBook(Book book)
        {
            int index = Array.IndexOf(Books, book);
            if (index >= 0)
            {
                Books[index] = null;
                CurrentBookCount--;
                Console.WriteLine("Book Is removed");
            }
        }
        public void DisplyBook()
        {
            for (int i = 0; i < CurrentBookCount; i++)
            {
                Console.WriteLine(Books[i]);
            }
        }
        public void BorrowBook(Book book)
        {
            if (CurrentBorrowedBookCount < BorrowedBooks.Length)
            {
                Books[CurrentBorrowedBookCount] = book;
                CurrentBorrowedBookCount++;
                Console.WriteLine("Book Is Borrowed");
            }
            else
            {
                Console.WriteLine("sorry can not borrow");
            }
        }

    }
}
