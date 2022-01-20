using Microsoft.AspNetCore.Mvc;
using Ontaz.Service.InterfaceServices;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ontaz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;   
        }
        // GET: api/<CountryController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _countryService.Getcountries();

            return Ok(result);
        }

    }
}
