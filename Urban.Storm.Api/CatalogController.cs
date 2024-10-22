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
           
        var items = new List<Item>(){
            new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m),
            new Item("Shorts", "Ohio State shorts.", "Nike", 44.99m),
        };
        return Ok(items);
        }
    }
}
