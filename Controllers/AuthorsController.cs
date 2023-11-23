using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Libreria_CESAR.Data.Services;
using Libreria_CESAR.Data.ViewModels;

namespace Libreria_CESAR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private AuthorsService _authorsService;

        public AuthorsController(AuthorsService authorsService)
        {
            _authorsService = authorsService;
        }


        [HttpPost("add-author")]
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {
            _authorsService.AddAuthor(author);
            return Ok();
        }
    }
}
