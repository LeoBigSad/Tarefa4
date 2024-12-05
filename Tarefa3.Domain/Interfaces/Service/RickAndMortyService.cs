using Tarefa3.Domain.Models;

namespace Tarefa3.Domain.Interfaces.Service
{
    public interface IRickAndMortyService
    {
        Task<CharacterResponse> GetCharacterByIdAsync(int id);
    }
}