
using Biblioteca_2._0.Services.Books;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca_2._0.Controllers.Books
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookDeleteController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookDeleteController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpDelete("Eliminar/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
            return Ok("Libro eliminado con exito");
        }
    }
}