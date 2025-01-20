using exercise.wwwapi.Models;
using exercise.wwwapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.wwwapi.Endpoints
{
    public static class BooksEndpoint
    {
        public static void ConfigureBookEndpoints(this WebApplication app)
        {
            var books = app.MapGroup("books");

            books.MapGet("/", GetBooks);

            books.MapGet("/{id}", GetBook);



            books.MapPost("/", AddBook);

            books.MapDelete("/{id}", DeleteBook);
            books.MapPut("/{id}", UpdateBooks);


        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> UpdateBooks(BookRepository bookrepository, int id, string title,string author, string genre, int numpages)
        {
            var book = bookrepository.UpdateEntity(id, title, author, genre, numpages);
                return Results.Ok(book);

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBook(BookRepository bookrepository, int id)
        {
            var book = bookrepository.GetEntity(id);
            return Results.Ok(book);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteBook(BookRepository bookrepository, int id)
        {
            var deleted = bookrepository.DeleteBook(id);

            return Results.Ok(deleted);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> AddBook( BookRepository bookrepository, Book book)
        {
            bookrepository.AddBook(book);

            return Results.Ok(book);


        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(BookRepository bookrepository)
        {
            var books = bookrepository.GetCollection();
            return Results.Ok(books);

        }
    }
}
