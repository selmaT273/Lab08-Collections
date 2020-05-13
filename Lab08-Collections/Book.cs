using System;
namespace Lab08_Collections
{
    // Book constructor
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int NumberOfPages { get; set; }
        public Genre Genre { get; set; }

    }

    // List we can iterate over limited to only these genres
    public enum Genre
    {
        Drama,
        Nonfiction,
        SciFi,
        Action,
        Fiction,
        Romance
    }
}
