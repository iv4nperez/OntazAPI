using Microsoft.AspNetCore.Mvc;
using Ontaz.Service.InterfaceServices;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ontaz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService; 
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<IActionResult> Get(bool AddPromotions)
        {
            var result = await _categoryService.GetCategories(AddPromotions);

       
            return Ok(result);
        }

    }
}
