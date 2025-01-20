using exercise.wwwapi.Models;

namespace exercise.wwwapi.Data
{
    public class BookCollection
    {
        private List<Book> _books = new List<Book>()
        {
            new Book() { Id = 0, Title="The Shining",Author="Stephen King", Genre = "Horror", NumPages = 200},
            new Book() { Id = 1, Title="Harry Potter",Author="JK Rowling", Genre = "Fantasy ", NumPages = 300},
        };

        public Book AddBook(Book book)
        {
            int maxId = _books.Any() ? _books.Max(book => book.Id) : 0;
            book.Id = maxId+1;
            _books.Add(book);
            return book;
        }

        public Book Delete(int id)
        {
     
            var deletedBook = _books.FirstOrDefault(x => x.Id == id);
            if (deletedBook != null) { _books.Remove(deletedBook); }

            return deletedBook;
        }

        public Book GetBook(int id)
        {
            var book = _books.FirstOrDefault(x => x.Id == id);
            return book;
        }

        public Book UpdateBook(int id, string title,string author,string genre, int numpages )
        {
            var book = _books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                throw new Exception($"No book found with id {id}");
            }
            book.Title = title;
            book.Author = author;   
            book.Genre = genre;
            book.NumPages = numpages;
            return book;
        }

        public List<Book> GetAll()
        {
            return _books.ToList();
        }
    }
}
