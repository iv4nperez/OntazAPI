using Microsoft.AspNetCore.Mvc;
using Ontaz.Service.InterfaceServices;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ontaz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] long IdService)
        {
            var result = await _productService.GetProductByService(IdService);
            return Ok(result);
        }

    }
}
