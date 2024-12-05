using Tarefa3.Data.Rest.Models;

namespace Tarefa3.Data.Rest.Repository
{
    public class RickAndMortyRepository : BaseRepository
    {
        private const string RickAndMortyBaseUrl = "https://rickandmortyapi.com/api/";

        public RickAndMortyRepository() : base(RickAndMortyBaseUrl)
        {
        }

        public async Task<CharacterResponse> GetCharacterByIdAsync(int id)
        {
            return await GetAsync<CharacterResponse>($"character/{id}");
        }

    }
}

