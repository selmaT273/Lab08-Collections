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
    }
}
