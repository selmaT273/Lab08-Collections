using System;

namespace Lab08_Collections
{
    class Program
    {
        public static Library<Book> Library { get; set; }
        public static List<Book> Bookbag { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pat's Lending Library");

            Library = new Library<Book>();
            // Bookbag = new List<Book>();
            LoadBooks();
            UserInterface();

        }

        static void LoadBooks()
        {
            Library.AddBook(new Book()
            {
                Title = "Harry Potter"
            }
            );

            Library.AddBook(new Book()
            {
                Title = "Lord of the Flies"
            }
            );

            Console.WriteLine($"{Library}");
        }

        static void UserInterface()
        {
            while (true)
            {
                Console.WriteLine("Please select one:");
                Console.WriteLine("view all books");
                Console.WriteLine("add a book");
                Console.WriteLine("borrow a book");
                Console.WriteLine("return a book");
                Console.WriteLine("view book bag");
                Console.WriteLine("exit");

                string userChoice = Console.ReadLine().ToLower();

                if (userChoice == "view all books")
                {
                    Console.WriteLine($"{Library}");
                }
                else if (userChoice == "add a book")
                {
                    Console.WriteLine("Please enter the title");
                    string title = Console.ReadLine();

                    Console.WriteLine("Please enter the author's first name");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Please enter the author's last name");
                    string lastName = Console.ReadLine();

                    Console.WriteLine("Please enter the number of pages");
                    int numberOfPages = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the genre");
                    Genre genre = (Genre)Enum.Parse(typeof(Genre), Console.ReadLine());

                    Author author = new Author(firstName, lastName);

                    Book book = new Book()
                    {
                        Title = title,
                        Author = author,
                        NumberOfPages = numberOfPages,
                        Genre = genre
                    };

                    Library.AddBook(book);

                }

                if(userChoice == "exit")
                {
                    break;
                }

            }


        }

        static void AddABook(string title, string firstName, string lastName, int numberOfPages, Genre genre)
        {
            Book book = new Book()
            {
                Title = title,
                Author = new Author()
                {
                    FirstName = firstName,
                    LastName = lastName
                },
                NumberOfPages = numberOfPages,
                Genre = genre
            };

            Library.AddBook(book);
        }
    }
}
