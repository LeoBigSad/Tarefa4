using Tarefa3.Data.Rest.Models;

namespace Tarefa3.Data.Rest.Repository
{
    public class ViaCepRepository : BaseRepository
    {
        private const string ViaCepBaseUrl = "https://viacep.com.br/ws/";

        public ViaCepRepository() : base(ViaCepBaseUrl)
        {
        }

        public async Task<PersonAddress> GetAddressByPersonIdAsync(string cep)
        {
            return await GetAsync<PersonAddress>($"{cep}/json");
        }

    }
}
