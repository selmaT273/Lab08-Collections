using System;
using Lab08_Collections;
using Xunit;

namespace Collections_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddBookToLibraryTest()
        {
            // Arrange
            Library<Book> library = new Library<Book>();

            Book book = new Book
            {
                Title = "War and Peace",
                Author = new Author(),
                NumberOfPages = 1000,
                Genre = Genre.Nonfiction,
            };

            // Act
            library.AddBook(book);

            // Assert
            Assert.Equal(1, library.Count);
            
            

        }

        [Fact]
        public void CanRemoveBookFromLibraryTest()
        {
            // Arrange
            Library<Book> library = new Library<Book>();

            Book book1 = new Book
            {
                Title = "War and Peace",
            };

            Book book2 = new Book
            {
                Title = "Harry Potter",
            };

            Book book3 = new Book
            {
                Title = "Lord of the rings",
            };

            // Act
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            library.RemoveBook(book1);

            // Assert
            Assert.False(library.IsAvailable(book1));
            Assert.Equal("Lord of the rings", library[1].Title);



        }
    }
}
