using Microsoft.AspNetCore.Mvc;
using Tarefa3.Domain.Interfaces.Service;

namespace Tarefa3.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly IRickAndMortyService _rickAndMortyService;

        public CharacterController(IRickAndMortyService rickAndMortyService)
        {
            _rickAndMortyService = rickAndMortyService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCharacterById(int id)
        {
            var character = await _rickAndMortyService.GetCharacterByIdAsync(id);
            if (character == null)
            {
                return NotFound();
            }
            return Ok(character);
        }
    }
}