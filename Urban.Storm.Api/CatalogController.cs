using Microsoft.AspNetCore.Mvc;
using Urban.Storm.Domain.Catalog;

namespace Urban.Storm.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase // Fixed typo in class name
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("hello world.");
        }
    }
}
