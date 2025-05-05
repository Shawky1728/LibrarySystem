namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Library System ^_^ ");
            Library MyLibrary = new Library();
            Console.WriteLine("------------------------------");
            while (true)
            {
                Console.WriteLine("Are you Librarian or User (L or U)");
                string input = Console.ReadLine().ToUpper();
                if (!char.TryParse(input, out char UserType))
                {
                    Console.Clear();
                    Console.WriteLine("Enter Valid Input");
                    continue;
                }

                if (UserType == 'L')
                {
                    Console.WriteLine("Enter Your Name");
                    Librarian l1 = new Librarian(Console.ReadLine());
                    Console.WriteLine($"Welcome {l1.Name}");
                    Console.WriteLine("Choose Add(A) or Remove (R) or Display(D)");
                    string input2 = Console.ReadLine().ToUpper();
                    if (!char.TryParse(input2, out char Action))
                    {
                        Console.Clear();
                        Console.WriteLine("Enter Valid Input");
                        continue;
                    }

                    switch (Action)
                    {
                        case 'A':
                            Console.WriteLine("Book Title");
                            string bookTitle = Console.ReadLine();
                            Console.WriteLine("Book Author");
                            string bookAuthor = Console.ReadLine();
                            Console.WriteLine("Book Year");
                            int bookYear = int.Parse(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookTitle,
                                Author= bookAuthor,
                                Year= bookYear
                            };
                            l1.AddBook(book,MyLibrary);
                            
                            break;
                        case 'R':
                            Console.WriteLine("Book Title");
                            bookTitle = Console.ReadLine();
                            Console.WriteLine("Book Author");
                            bookAuthor = Console.ReadLine();
                            Console.WriteLine("Book Year");
                            bookYear = int.Parse(Console.ReadLine());
                            book = new Book()
                            {
                                Title = bookTitle,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            l1.RemoveBook(book, MyLibrary);

                            break;
                        case 'D':
                            Console.WriteLine("Book List Is:");
                            l1.DisplyBooks(MyLibrary);
                            break;
                        default:
                             return;
                    }

                }
                else if(UserType == 'G')
                {
                    Console.WriteLine("Enter Your Name");
                    LibraryUser l1 = new LibraryUser(Console.ReadLine());
                    Console.WriteLine($"Welcome {l1.Name}");
                    Console.WriteLine("Choose Disply (D) or Borrow (B))");
                    string input2 = Console.ReadLine().ToUpper();
                    if (!char.TryParse(input2, out char Action))
                    {
                        Console.Clear();
                        Console.WriteLine("Enter Valid Input");
                        continue;
                    }

                    switch (Action)
                    {
                        case 'B':
                            Console.WriteLine("Book Title");
                            string bookTitle = Console.ReadLine();
                            Console.WriteLine("Book Author");
                            string bookAuthor = Console.ReadLine();
                            Console.WriteLine("Book Year");
                            int bookYear = int.Parse(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookTitle,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            l1.BorrowBooks(book, MyLibrary);

                            break;
                        case 'D':
                            Console.WriteLine("Book List Is:");
                            l1.DisplyBooks(MyLibrary);
                            break;
                        default:
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Enter L Or G");
                }
            }
        }
    }
}
