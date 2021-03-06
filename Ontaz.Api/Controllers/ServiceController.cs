using Microsoft.AspNetCore.Mvc;
using Ontaz.Service.DTOs.Params;
using Ontaz.Service.InterfaceServices;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ontaz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        // GET: api/<ServiceController>
        [HttpGet]
        public async Task<IActionResult> Get(long IdCategory)
        {
            var result = await _serviceService.GetServices(IdCategory);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetServiceById")]
        public async Task<IActionResult> GetServiceById(long IdService)
        {
            var result = await _serviceService.GetServiceByID(IdService);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetServiceByIdUser")]
        public async Task<IActionResult> GetServiceByIdUser(long IdUser)
        {
            var result = await _serviceService.GetServiceByIdUser(IdUser);
            return Ok(result);
        }

        [HttpPost]
        [Route("SaveOrEdit")]
        public async Task<IActionResult> SaveOrEdit(ServiceParamModel paramModel)
        {
            var result = await _serviceService.SaveOrEdit(paramModel);
            return Ok(result);
        }
    }
}
