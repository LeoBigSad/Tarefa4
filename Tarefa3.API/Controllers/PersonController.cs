using Microsoft.AspNetCore.Mvc;
using Tarefa3.Domain.Interfaces.Service;

namespace Tarefa3.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly IViaCepService _viaCepService;

        public PersonController(IPersonService personService, IViaCepService viaCepService)
        {
            _personService = personService;
            _viaCepService = viaCepService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var people = _personService.GetAll();
            return Ok(people);
        }

        [HttpGet("{id}/address")]
        public async Task<IActionResult> GetAddressByPersonId(int id)
        {
            try
            {
                var address = await _viaCepService.GetAddressByPersonIdAsync(id);
                return Ok(address);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}