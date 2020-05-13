using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab08_Collections
{
    public class Library<T> : IEnumerable<T>
    {
        // Fields
        T[] books;
        int count = 0;

        // Constructors

        
        public Library(int libraryCapacity)
        {
            if (libraryCapacity <= 0) throw new ArgumentException();

            books = new T[libraryCapacity];
        }

        public Library() : this(10)
        {

        }

      
        // Properties
        public int Count => count;

        public T this[int index] => books[index];

        public void AddBook(T book)
        { 
                if(books.Length == count)
            {
                Array.Resize(ref books, count * 2);
            }

            books[count] = book;
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
