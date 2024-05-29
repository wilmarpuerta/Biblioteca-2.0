
using Biblioteca_2._0.Models;

namespace Biblioteca_2._0.Services.Books
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}