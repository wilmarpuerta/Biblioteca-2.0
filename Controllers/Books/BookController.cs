
using Biblioteca_2._0.Models;
using Biblioteca_2._0.Services.Books;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca_2._0.Controllers.Books
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet("listar")]
        public IEnumerable<Book> GetBooksAll()
        {
            return _bookRepository.GetBooks();
        }

        [HttpGet("listar/{id}")]
        public Book GetBookById(int id)
        {
            return _bookRepository.GetBookById(id);
        }
    }
}