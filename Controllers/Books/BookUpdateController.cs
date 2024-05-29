
using Biblioteca_2._0.Models;
using Biblioteca_2._0.Services.Books;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca_2._0.Controllers.Books
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookUpdateController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookUpdateController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpPut("Actualizar/{id}")]
        public IActionResult BookUpdate(int id, [FromBody] Book book)
        {
            var bookUpdate = _bookRepository.GetBookById(id);

            bookUpdate.Title = book.Title;
            bookUpdate.Pages = book.Pages;
            bookUpdate.Language = book.Language;
            bookUpdate.PublicationDate = book.PublicationDate;
            bookUpdate.Description = book.Description;

            _bookRepository.UpdateBook(id, book);
            
            return Ok("Libro actualizado");
        }
    }
}