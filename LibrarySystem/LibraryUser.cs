using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class LibraryUser:User
    {
        public LibraryCard Card { get; set; }

        public LibraryUser(string name)
        {
            Name = name;
        }

        public void BorrowBooks(Book book,Library library)
        {
             library.BorrowBook(book);
        }
    }
}
