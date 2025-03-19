using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Librarian:User
    {
        public int EmployeeNumber { get; set; }

        public Librarian(string name)
        {
            Name = name;
        }

        public void AddBook(Book book,Library library)
        {
            library.Add(book);
        }

        public void RemoveBook(Book book,Library library)
        {
            library.RemoveBook(book);
            Console.WriteLine("book is removed");
        }

    }
}
