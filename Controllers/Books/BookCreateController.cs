
using Biblioteca_2._0.Models;
using Biblioteca_2._0.Services.Books;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca_2._0.Controllers.Books
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookCreateController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookCreateController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        [HttpPost("Crear")]
        public IActionResult Create([FromBody] Book book)
        {
            _bookRepository.AddBook(book);
            return Ok("El libro se creo exitosamente");
        }
    }
}