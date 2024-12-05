using Tarefa3.Domain.Interfaces.Service;
using Tarefa3.Domain.Models;
using Tarefa3.Data.Rest.Repository;

namespace Tarefa3.Application.Services
{
    public class RickAndMortyService : IRickAndMortyService
    {
        private readonly RickAndMortyRepository _rickAndMortyRepository;

        public RickAndMortyService(RickAndMortyRepository rickAndMortyRepository)
        {
            _rickAndMortyRepository = rickAndMortyRepository;
        }

        public async Task<Tarefa3.Domain.Models.CharacterResponse> GetCharacterByIdAsync(int id)
        {
            var characterResponse = await _rickAndMortyRepository.GetCharacterByIdAsync(id);
            return new Tarefa3.Domain.Models.CharacterResponse
            {
                Id = characterResponse.Id,
                Name = characterResponse.Name,
                Status = characterResponse.Status,
                Species = characterResponse.Species,
                Gender = characterResponse.Gender,
                Origin = new Tarefa3.Domain.Models.Origin
                {
                    Name = characterResponse.Origin.Name,
                    Url = characterResponse.Origin.Url
                },
                Location = new Tarefa3.Domain.Models.Location
                {
                    Name = characterResponse.Location.Name,
                    Url = characterResponse.Location.Url
                },
                Image = characterResponse.Image,
            };
        }
    }
}
