
using Biblioteca_2._0.Data;
using Biblioteca_2._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca_2._0.Services.Books
{
    public class BookRepository : IBookRepository
    {
        private readonly BaseContext _context;

        public BookRepository(BaseContext context)
        {
            _context = context;
        }
        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = _context.Books.FirstOrDefault(book => book.Id == id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public Book GetBookById(int id)
        {
            return _context.Books.Find(id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public void UpdateBook(int id, [FromBody] Book book)
        {
            var bookUpdate = _context.Books.FirstOrDefault(b => b.Id == id);
            bookUpdate.Title = book.Title;
            bookUpdate.Pages = book.Pages;
            bookUpdate.Language = book.Language;
            bookUpdate.PublicationDate = book.PublicationDate;
            bookUpdate.Description = book.Description;
            
            _context.Books.Update(bookUpdate);
            _context.SaveChanges();
        }
    }
}