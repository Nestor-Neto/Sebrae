using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Domain.Repositories;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaController : ControllerBase
    {
        private readonly IContaService _contaServices;

        public ContaController(IContaService contaServices)
        {
            _contaServices = contaServices;
        }

        [HttpGet("/Conta")]
        public async Task<IActionResult> Index()
        {
            var result = await _contaServices.Get();

            return result == null ? NotFound() : Ok(result);
        }
    }
}
