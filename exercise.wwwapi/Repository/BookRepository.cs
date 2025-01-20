using exercise.wwwapi.Data;
using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public class BookRepository
    {
        private BookCollection _bookCollection;

        public BookRepository(BookCollection bookCollection)
        {
            _bookCollection = bookCollection;
        }

        public Book AddBook(Book book)
        {
            _bookCollection.AddBook(book);
            return book;
        }

        public Book DeleteBook(int id)
        {
            return _bookCollection.Delete(id);
        }

  

        public List<Book> GetCollection()
        {
            return _bookCollection.GetAll();
        }

        public Book GetEntity(int id)
        {
            return _bookCollection.GetBook(id);
        }

   

        public Book UpdateEntity(int id, string title, string author, string genre, int numpages)
        {
            return _bookCollection.UpdateBook(id, title, author, genre, numpages);
        }
    }
}

