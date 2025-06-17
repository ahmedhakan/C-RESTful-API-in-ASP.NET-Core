using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models; // Assuming Product model is in this namespace

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            // TODO: add product to db
            return CreatedAtAction(nameof(CreateProduct), new {id = product.id}, product);
        }
    }
}
