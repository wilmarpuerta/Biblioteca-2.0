
using Biblioteca_2._0.Models;

namespace Biblioteca_2._0.Services.Books
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
        void UpdateBook(int id, Book book);
        void DeleteBook(int id);
    }
}