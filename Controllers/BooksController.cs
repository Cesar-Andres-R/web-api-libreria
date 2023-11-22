using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Libreria_CESAR.Data.Models;
using Libreria_CESAR.Data.Services;
using Libreria_CESAR.Data.ViewModels;

namespace Libreria_CESAR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _booksService;


        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody] BookVM book)
        {
            _booksService.AddBook(book);
            return Ok();
        }
    }
}
